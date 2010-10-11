namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteClosable_))]
	public abstract partial class SQLiteClosable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteClosable()
		{
			InitJNI();
		}
		protected SQLiteClosable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased2790;
		protected abstract void onAllReferencesReleased();
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer2791;
		protected virtual void onAllReferencesReleasedFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2791);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2791);
		}
		internal static global::MonoJavaBridge.MethodId _acquireReference2792;
		public virtual void acquireReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._acquireReference2792);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._acquireReference2792);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReference2793;
		public virtual void releaseReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._releaseReference2793);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReference2793);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReferenceFromContainer2794;
		public virtual void releaseReferenceFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2794);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2794);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteClosable2795;
		public SQLiteClosable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._SQLiteClosable2795);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleased2790 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2791 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._acquireReference2792 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReference2793 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2794 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._SQLiteClosable2795 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteClosable))]
	public sealed partial class SQLiteClosable_ : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteClosable_()
		{
			InitJNI();
		}
		internal SQLiteClosable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased2796;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased2796);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable_.staticClass, global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased2796);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
			global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased2796 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable_.staticClass, "onAllReferencesReleased", "()V");
		}
	}
}
