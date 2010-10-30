namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteOpenHelper_))]
	public abstract partial class SQLiteOpenHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteOpenHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteOpenHelper.staticClass, "close", "()V", ref global::android.database.sqlite.SQLiteOpenHelper._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void onCreate(android.database.sqlite.SQLiteDatabase arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.database.sqlite.SQLiteDatabase getWritableDatabase()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", ref global::android.database.sqlite.SQLiteOpenHelper._m2) as android.database.sqlite.SQLiteDatabase;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.database.sqlite.SQLiteDatabase getReadableDatabase()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", ref global::android.database.sqlite.SQLiteOpenHelper._m3) as android.database.sqlite.SQLiteDatabase;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void onUpgrade(android.database.sqlite.SQLiteDatabase arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onOpen(android.database.sqlite.SQLiteDatabase arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V", ref global::android.database.sqlite.SQLiteOpenHelper._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SQLiteOpenHelper(android.content.Context arg0, java.lang.String arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteOpenHelper._m6.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteOpenHelper._m6 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SQLiteOpenHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteOpenHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteOpenHelper"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteOpenHelper))]
	internal sealed partial class SQLiteOpenHelper_ : android.database.sqlite.SQLiteOpenHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteOpenHelper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onCreate(android.database.sqlite.SQLiteDatabase arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteOpenHelper_.staticClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", ref global::android.database.sqlite.SQLiteOpenHelper_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onUpgrade(android.database.sqlite.SQLiteDatabase arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteOpenHelper_.staticClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", ref global::android.database.sqlite.SQLiteOpenHelper_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static SQLiteOpenHelper_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteOpenHelper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteOpenHelper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
