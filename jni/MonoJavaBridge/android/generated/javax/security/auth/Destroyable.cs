namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.security.auth.Destroyable_))]
	public interface Destroyable  : global::MonoJavaBridge.IJavaObject 
	{
		void destroy();
		bool isDestroyed();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.auth.Destroyable))]
	public sealed partial class Destroyable_ : java.lang.Object, Destroyable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Destroyable_()
		{
			InitJNI();
		}
		internal Destroyable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy23617;
		 void javax.security.auth.Destroyable.destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.Destroyable_._destroy23617);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.Destroyable_.staticClass, global::javax.security.auth.Destroyable_._destroy23617);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed23618;
		 bool javax.security.auth.Destroyable.isDestroyed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Destroyable_._isDestroyed23618);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Destroyable_.staticClass, global::javax.security.auth.Destroyable_._isDestroyed23618);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Destroyable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Destroyable"));
			global::javax.security.auth.Destroyable_._destroy23617 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Destroyable_.staticClass, "destroy", "()V");
			global::javax.security.auth.Destroyable_._isDestroyed23618 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Destroyable_.staticClass, "isDestroyed", "()Z");
		}
	}
}
