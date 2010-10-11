namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteTransactionListener_))]
	public interface SQLiteTransactionListener  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _onBegin2933;
		 void android.database.sqlite.SQLiteTransactionListener.onBegin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onBegin2933);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onBegin2933);
		}
		internal static global::MonoJavaBridge.MethodId _onCommit2934;
		 void android.database.sqlite.SQLiteTransactionListener.onCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onCommit2934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onCommit2934);
		}
		internal static global::MonoJavaBridge.MethodId _onRollback2935;
		 void android.database.sqlite.SQLiteTransactionListener.onRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_._onRollback2935);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteTransactionListener_.staticClass, global::android.database.sqlite.SQLiteTransactionListener_._onRollback2935);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteTransactionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteTransactionListener"));
			global::android.database.sqlite.SQLiteTransactionListener_._onBegin2933 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onBegin", "()V");
			global::android.database.sqlite.SQLiteTransactionListener_._onCommit2934 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onCommit", "()V");
			global::android.database.sqlite.SQLiteTransactionListener_._onRollback2935 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteTransactionListener_.staticClass, "onRollback", "()V");
		}
	}
}
