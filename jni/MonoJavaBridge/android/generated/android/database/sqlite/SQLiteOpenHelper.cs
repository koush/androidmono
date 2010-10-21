namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteOpenHelper_))]
	public abstract partial class SQLiteOpenHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteOpenHelper()
		{
			InitJNI();
		}
		protected SQLiteOpenHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close4791;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper._close4791);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._close4791);
		}
		internal static global::MonoJavaBridge.MethodId _onCreate4792;
		public abstract void onCreate(android.database.sqlite.SQLiteDatabase arg0);
		internal static global::MonoJavaBridge.MethodId _getWritableDatabase4793;
		public virtual global::android.database.sqlite.SQLiteDatabase getWritableDatabase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper._getWritableDatabase4793)) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._getWritableDatabase4793)) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _getReadableDatabase4794;
		public virtual global::android.database.sqlite.SQLiteDatabase getReadableDatabase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper._getReadableDatabase4794)) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._getReadableDatabase4794)) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _onUpgrade4795;
		public abstract void onUpgrade(android.database.sqlite.SQLiteDatabase arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _onOpen4796;
		public virtual void onOpen(android.database.sqlite.SQLiteDatabase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper._onOpen4796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._onOpen4796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteOpenHelper4797;
		public SQLiteOpenHelper(android.content.Context arg0, java.lang.String arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteOpenHelper.staticClass, global::android.database.sqlite.SQLiteOpenHelper._SQLiteOpenHelper4797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteOpenHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteOpenHelper"));
			global::android.database.sqlite.SQLiteOpenHelper._close4791 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteOpenHelper._onCreate4792 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			global::android.database.sqlite.SQLiteOpenHelper._getWritableDatabase4793 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteOpenHelper._getReadableDatabase4794 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteOpenHelper._onUpgrade4795 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			global::android.database.sqlite.SQLiteOpenHelper._onOpen4796 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			global::android.database.sqlite.SQLiteOpenHelper._SQLiteOpenHelper4797 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteOpenHelper))]
	public sealed partial class SQLiteOpenHelper_ : android.database.sqlite.SQLiteOpenHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteOpenHelper_()
		{
			InitJNI();
		}
		internal SQLiteOpenHelper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate4798;
		public override void onCreate(android.database.sqlite.SQLiteDatabase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper_._onCreate4798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper_.staticClass, global::android.database.sqlite.SQLiteOpenHelper_._onCreate4798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpgrade4799;
		public override void onUpgrade(android.database.sqlite.SQLiteDatabase arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper_._onUpgrade4799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteOpenHelper_.staticClass, global::android.database.sqlite.SQLiteOpenHelper_._onUpgrade4799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteOpenHelper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteOpenHelper"));
			global::android.database.sqlite.SQLiteOpenHelper_._onCreate4798 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper_.staticClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			global::android.database.sqlite.SQLiteOpenHelper_._onUpgrade4799 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteOpenHelper_.staticClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
		}
	}
}
