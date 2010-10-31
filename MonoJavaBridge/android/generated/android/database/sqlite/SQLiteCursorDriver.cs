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
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.database.Cursor android.database.sqlite.SQLiteCursorDriver.query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteCursorDriver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.database.sqlite.SQLiteCursorDriver.cursorDeactivated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorDeactivated", "()V", ref global::android.database.sqlite.SQLiteCursorDriver_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.database.sqlite.SQLiteCursorDriver.cursorRequeried(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorRequeried", "(Landroid/database/Cursor;)V", ref global::android.database.sqlite.SQLiteCursorDriver_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.database.sqlite.SQLiteCursorDriver.cursorClosed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorClosed", "()V", ref global::android.database.sqlite.SQLiteCursorDriver_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.database.sqlite.SQLiteCursorDriver.setBindArguments(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "setBindArguments", "([Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteCursorDriver_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SQLiteCursorDriver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursorDriver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursorDriver"));
		}
	}
}
