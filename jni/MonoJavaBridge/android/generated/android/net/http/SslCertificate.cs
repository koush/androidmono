namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslCertificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SslCertificate()
		{
			InitJNI();
		}
		protected SslCertificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DName : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DName()
			{
				InitJNI();
			}
			protected DName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getDName5407;
			public virtual global::java.lang.String getDName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getDName5407)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getDName5407)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getCName5408;
			public virtual global::java.lang.String getCName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getCName5408)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getCName5408)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getOName5409;
			public virtual global::java.lang.String getOName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getOName5409)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getOName5409)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getUName5410;
			public virtual global::java.lang.String getUName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getUName5410)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getUName5410)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _DName5411;
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._DName5411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.http.SslCertificate.DName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate$DName"));
				global::android.net.http.SslCertificate.DName._getDName5407 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getCName5408 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getOName5409 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getUName5410 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._DName5411 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString5412;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._toString5412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._toString5412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState5413;
		public static global::android.os.Bundle saveState(android.net.http.SslCertificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._saveState5413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState5414;
		public static global::android.net.http.SslCertificate restoreState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._restoreState5414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBeforeDate5415;
		public virtual global::java.util.Date getValidNotBeforeDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotBeforeDate5415)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBeforeDate5415)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBefore5416;
		public virtual global::java.lang.String getValidNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotBefore5416)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBefore5416)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfterDate5417;
		public virtual global::java.util.Date getValidNotAfterDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotAfterDate5417)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfterDate5417)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfter5418;
		public virtual global::java.lang.String getValidNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotAfter5418)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfter5418)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedTo5419;
		public virtual global::android.net.http.SslCertificate.DName getIssuedTo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getIssuedTo5419)) as android.net.http.SslCertificate.DName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedTo5419)) as android.net.http.SslCertificate.DName;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedBy5420;
		public virtual global::android.net.http.SslCertificate.DName getIssuedBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getIssuedBy5420)) as android.net.http.SslCertificate.DName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedBy5420)) as android.net.http.SslCertificate.DName;
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate5421;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate5421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate5422;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.util.Date arg2, java.util.Date arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate5422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate5423;
		public SslCertificate(java.security.cert.X509Certificate arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate5423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslCertificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate"));
			global::android.net.http.SslCertificate._toString5412 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._saveState5413 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;");
			global::android.net.http.SslCertificate._restoreState5414 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;");
			global::android.net.http.SslCertificate._getValidNotBeforeDate5415 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBeforeDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotBefore5416 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getValidNotAfterDate5417 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfterDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotAfter5418 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getIssuedTo5419 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._getIssuedBy5420 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._SslCertificate5421 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.http.SslCertificate._SslCertificate5422 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)V");
			global::android.net.http.SslCertificate._SslCertificate5423 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V");
		}
	}
}
