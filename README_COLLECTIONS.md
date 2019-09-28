# Livet.Collections

Livet collections is a copy of StatefulModel.
Original is using `StatefulModel` namespace, this package is using `Livet.Collections` namespace.

There are same name classes as `Livet.EventListeners` package in `Livet.Collections`.
The classes are `PropertyChangedEventListener` and `CollectionChangedEventListener`.
It is really similer, it is almost all same. Because the original creator is same.
But there are little bit changes. I decided to leave both classes sets, because I couldn't merge it continues supporting .NET Framework 4.5.2(.NET Standard 1.1).

If you want to use theses classes, I recommended `Livet.Collections` ones.
Because, it is latest version of the classes.

## NotifyCollections

the classes that implement ISynchronizableNotifyChangedCollection < T > have ToSyncedXXX Methods (XXX ... any ISynchronizableNotifyChangedCollection < T >).

ToSyncedXXX Methods is creating one-way synchronized collection with source collection. 

![image](./images/collectionoverview.png)
![image](./images/readonlywrapper.png)

###Simple Usage
```csharp

	//thread-safe collection
	var source = new ObservableSynchronizedCollection<int>(Enumerable.Range(1,3));
	// sorted collection
	var sortedSource = new SortedObservableCollection<int,int>(Enumerable.Range(1,4),i => i);
	//UI thread
	var context = new DispatcherSynchronizationContext(Dispatcher.CurrentDispatcher);
	//SynchronizationContext(send) bouded collection.
	var dispatcherSource = new SynchronizationContextCollection<int>(Enumerable.Range(1,5),context);

```

### Sync Collections
While creating one-way synchronized collection, this method lock source collection, so no leak items.
![image](./images/syncCollections.png)
### Detach
ISynchronizableNotifyChangedCollection < T > is IDisposable. When Dispose() called , all EventHandler from source collection will be detached.
![image](./images/detach.png)

## EventListeners

PropertyChangedEventListener/CollectionChangedEventListener
```csharp
	//use collection initializer
	var listener = new PropertyChangedEventListener(NotifyObject)
	{
		{"Property1", (sender,e) => Hoge()},
		{"Property2", (semder,e) => Huge()}
	};
	
	listener.RegisterHandler((sender,e) => Hage());
	listerer.RegisterHandler("Property3",(semder,e) => Fuga());
	
	//when dispose() called, detach all handler
	listerner.Dispose();
```
### WeakEventListeners

- PropertyChangedWeakEventListener (PropertyChangedEventListener by weak event)
- CollectionChangedWeakEventListener (CollectionChangedWeakEventListener by weak event)
- WeakEventListener (allÅ]purpose weak event listener)

```csharp

	var button = new Button(){Width = 100,Height = 100};

	var weakListener = new WeakEventListener<RoutedEventHandler,RoutedEventArgs>(
		h => new RoutedEventHandler(h),
		h => button.Click += h,
		h => button.Click -= h,
		(sender,e) => button.Content = "Clicked!!");
