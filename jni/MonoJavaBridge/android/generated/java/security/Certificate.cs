namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Certificate_))]
	public interface Certificate  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String toString(bool arg0);
		void decode(java.io.InputStream arg0);
		void encode(java.io.OutputStream arg0);
		global::java.security.PublicKey getPublicKey();
		global::java.lang.String getFormat();
		global::java.security.Principal getGuarantor();
		global::java.security.Principal getPrincipal();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Certificate))]
	public sealed partial class Certificate_ : java.lang.Object, Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17195;
		 global::java.lang.String java.security.Certificate.toString(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Certificate_._toString17195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._toString17195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _decode17196;
		 void java.security.Certificate.decode(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Certificate_._decode17196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._decode17196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encode17197;
		 void java.security.Certificate.encode(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Certificate_._encode17197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._encode17197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey17198;
		 global::java.security.PublicKey java.security.Certificate.getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Certificate_._getPublicKey17198)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._getPublicKey17198)) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat17199;
		 global::java.lang.String java.security.Certificate.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Certificate_._getFormat17199)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._getFormat17199)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getGuarantor17200;
		 global::java.security.Principal java.security.Certificate.getGuarantor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Certificate_._getGuarantor17200)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._getGuarantor17200)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipal17201;
		 global::java.security.Principal java.security.Certificate.getPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Certificate_._getPrincipal17201)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Certificate_.staticClass, global::java.security.Certificate_._getPrincipal17201)) as java.security.Principal;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Certificate"));
			global::java.security.Certificate_._toString17195 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.security.Certificate_._decode17196 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "decode", "(Ljava/io/InputStream;)V");
			global::java.security.Certificate_._encode17197 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "encode", "(Ljava/io/OutputStream;)V");
			global::java.security.Certificate_._getPublicKey17198 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.Certificate_._getFormat17199 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.Certificate_._getGuarantor17200 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "getGuarantor", "()Ljava/security/Principal;");
			global::java.security.Certificate_._getPrincipal17201 = @__env.GetMethodIDNoThrow(global::java.security.Certificate_.staticClass, "getPrincipal", "()Ljava/security/Principal;");
		}
	}
}
