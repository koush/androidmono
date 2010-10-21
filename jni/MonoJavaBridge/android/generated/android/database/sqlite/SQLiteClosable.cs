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
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4689;
		protected abstract void onAllReferencesReleased();
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer4690;
		protected virtual void onAllReferencesReleasedFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer4690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer4690);
		}
		internal static global::MonoJavaBridge.MethodId _acquireReference4691;
		public virtual void acquireReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._acquireReference4691);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._acquireReference4691);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReference4692;
		public virtual void releaseReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._releaseReference4692);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReference4692);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReferenceFromContainer4693;
		public virtual void releaseReferenceFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer4693);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer4693);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteClosable4694;
		public SQLiteClosable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._SQLiteClosable4694);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleased4689 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer4690 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._acquireReference4691 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReference4692 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer4693 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._SQLiteClosable4694 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4695;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased4695);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteClosable_.staticClass, global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased4695);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
			global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased4695 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable_.staticClass, "onAllReferencesReleased", "()V");
		}
	}
}
