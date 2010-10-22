namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteTransactionListener_))]
	public partial interface SQLiteTransactionListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onBegin();
		void onCommit();
		void onRollback();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteTransactionListener))]
	public sealed partial class SQLiteTransactionListener_ : java.lang.Object, SQLiteTransactionListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteTransactionListener_()
		{
			InitJNI();
		}
		internal SQLiteTransactionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBegin4843;
		 void android.database.sqlite.SQLiteTransactionListener.onBegin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onBegin4843);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onBegin4843);
		}
		internal static global::MonoJavaBridge.MethodId _onCommit4844;
		 void android.database.sqlite.SQLiteTransactionListener.onCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onCommit4844);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onCommit4844);
		}
		internal static global::MonoJavaBridge.MethodId _onRollback4845;
		 void android.database.sqlite.SQLiteTransactionListener.onRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onRollback4845);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onRollback4845);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteTransactionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteTransactionListener"));
			global::android.database.sqlite.SQLiteTransactionListener_._onBegin4843 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onBegin", "()V");
			global::android.database.sqlite.SQLiteTransactionListener_._onCommit4844 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onCommit", "()V");
			global::android.database.sqlite.SQLiteTransactionListener_._onRollback4845 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onRollback", "()V");
		}
	}
}
