using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using Livet.Messaging;

namespace $rootnamespace$
{
    /*
     * 戻り値のある相互作用メッセージはResponsiveInteractionMessage<T>を継承して作成します。
     * Tは戻り値の型です。
     * 戻り値のない相互作用メッセージはInteractionMessageを継承して作成します。
     */
    public class $safeitemname$ : ResponsiveInteractionMessage<string>
    {
        //Viewでメッセージインスタンスを生成する時のためのコンストラクタ
        public $safeitemname$()
        {
        }

        //ViewModelからMessenger経由での発信目的でメッセージインスタンスを生成するためのコンストラクタ
        public $safeitemname$(string messageKey)
            : base(messageKey)
        {

        }

        /*
         * メッセージに保持させたい情報をプロパティとして定義してください。
         * Viewでバインド可能なプロパティにするために依存関係プロパティとして定義する事をお勧めします。
         * 通常依存関係プロパティはコードスニペット propdpを使用して定義します。
         * もし普通のプロパティとして定義したい場合はコードスニペット propを使用して定義します。
         */

        /// <summary>
        /// 派生クラスでは必ずオーバーライドしてください。Freezableオブジェクトとして必要な実装です。<br/>
        /// 通常このメソッドは、自身の新しいインスタンスを返すように実装します。
        /// </summary>
        /// <returns>自身の新しいインスタンス</returns>
        protected override System.Windows.Freezable CreateInstanceCore()
        {
            return new $safeitemname$();
        }
    }
}
