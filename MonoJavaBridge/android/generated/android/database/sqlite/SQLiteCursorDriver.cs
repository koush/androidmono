namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteCursorDriver_))]
	public partial interface SQLiteCursorDriver  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1);
		void cursorDeactivated();
		void cursorRequeried(android.database.Cursor arg0);
		void cursorClosed();
		void setBindArguments(java.lang.String[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteCursorDriver))]
	internal sealed partial class SQLiteCursorDriver_ : java.lang.Object, SQLiteCursorDriver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteCursorDriver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _query4728;
		global::android.database.Cursor android.database.sqlite.SQLiteCursorDriver.query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteCursorDriver_._query4728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _cursorDeactivated4729;
		void android.database.sqlite.SQLiteCursorDriver.cursorDeactivated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorDeactivated", "()V", ref global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated4729);
		}
		internal static global::MonoJavaBridge.MethodId _cursorRequeried4730;
		void android.database.sqlite.SQLiteCursorDriver.cursorRequeried(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorRequeried", "(Landroid/database/Cursor;)V", ref global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried4730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cursorClosed4731;
		void android.database.sqlite.SQLiteCursorDriver.cursorClosed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorClosed", "()V", ref global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed4731);
		}
		internal static global::MonoJavaBridge.MethodId _setBindArguments4732;
		void android.database.sqlite.SQLiteCursorDriver.setBindArguments(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "setBindArguments", "([Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments4732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SQLiteCursorDriver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursorDriver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursorDriver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
