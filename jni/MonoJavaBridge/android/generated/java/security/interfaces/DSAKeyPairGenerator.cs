namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAKeyPairGenerator_))]
	public partial interface DSAKeyPairGenerator  : global::MonoJavaBridge.IJavaObject 
	{
		void initialize(java.security.interfaces.DSAParams arg0, java.security.SecureRandom arg1);
		void initialize(int arg0, bool arg1, java.security.SecureRandom arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAKeyPairGenerator))]
	internal sealed partial class DSAKeyPairGenerator_ : java.lang.Object, DSAKeyPairGenerator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DSAKeyPairGenerator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize23896;
		void java.security.interfaces.DSAKeyPairGenerator.initialize(java.security.interfaces.DSAParams arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.interfaces.DSAKeyPairGenerator_._initialize23896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.interfaces.DSAKeyPairGenerator_.staticClass, global::java.security.interfaces.DSAKeyPairGenerator_._initialize23896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initialize23897;
		void java.security.interfaces.DSAKeyPairGenerator.initialize(int arg0, bool arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.interfaces.DSAKeyPairGenerator_._initialize23897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.interfaces.DSAKeyPairGenerator_.staticClass, global::java.security.interfaces.DSAKeyPairGenerator_._initialize23897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static DSAKeyPairGenerator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAKeyPairGenerator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAKeyPairGenerator"));
			global::java.security.interfaces.DSAKeyPairGenerator_._initialize23896 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAKeyPairGenerator_.staticClass, "initialize", "(Ljava/security/interfaces/DSAParams;Ljava/security/SecureRandom;)V");
			global::java.security.interfaces.DSAKeyPairGenerator_._initialize23897 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAKeyPairGenerator_.staticClass, "initialize", "(IZLjava/security/SecureRandom;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
