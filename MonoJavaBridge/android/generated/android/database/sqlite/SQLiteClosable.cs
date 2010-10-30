namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteClosable_))]
	public abstract partial class SQLiteClosable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteClosable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void onAllReferencesReleased();
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual void onAllReferencesReleasedFromContainer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V", ref global::android.database.sqlite.SQLiteClosable._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void acquireReference()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V", ref global::android.database.sqlite.SQLiteClosable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void releaseReference()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V", ref global::android.database.sqlite.SQLiteClosable._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void releaseReferenceFromContainer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V", ref global::android.database.sqlite.SQLiteClosable._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SQLiteClosable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteClosable._m5.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteClosable._m5 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._m5);
			Init(@__env, handle);
		}
		static SQLiteClosable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteClosable))]
	internal sealed partial class SQLiteClosable_ : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteClosable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable_.staticClass, "onAllReferencesReleased", "()V", ref global::android.database.sqlite.SQLiteClosable_._m0);
		}
		static SQLiteClosable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
