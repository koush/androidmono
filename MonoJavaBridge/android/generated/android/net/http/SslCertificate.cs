namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslCertificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SslCertificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DName : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String getDName()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate.DName._m0) as java.lang.String;
			}
			public new global::java.lang.String CName
			{
				get
				{
					return getCName();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::java.lang.String getCName()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate.DName._m1) as java.lang.String;
			}
			public new global::java.lang.String OName
			{
				get
				{
					return getOName();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.lang.String getOName()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate.DName._m2) as java.lang.String;
			}
			public new global::java.lang.String UName
			{
				get
				{
					return getUName();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::java.lang.String getUName()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate.DName._m3) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.http.SslCertificate.DName._m4.native == global::System.IntPtr.Zero)
					global::android.net.http.SslCertificate.DName._m4 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static DName()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.http.SslCertificate.DName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate$DName"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.os.Bundle saveState(android.net.http.SslCertificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslCertificate._m1.native == global::System.IntPtr.Zero)
				global::android.net.http.SslCertificate._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.net.http.SslCertificate restoreState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslCertificate._m2.native == global::System.IntPtr.Zero)
				global::android.net.http.SslCertificate._m2 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.SslCertificate;
		}
		public new global::java.util.Date ValidNotBeforeDate
		{
			get
			{
				return getValidNotBeforeDate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.Date getValidNotBeforeDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, "getValidNotBeforeDate", "()Ljava/util/Date;", ref global::android.net.http.SslCertificate._m3) as java.util.Date;
		}
		public new global::java.lang.String ValidNotBefore
		{
			get
			{
				return getValidNotBefore();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getValidNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate._m4) as java.lang.String;
		}
		public new global::java.util.Date ValidNotAfterDate
		{
			get
			{
				return getValidNotAfterDate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.Date getValidNotAfterDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, "getValidNotAfterDate", "()Ljava/util/Date;", ref global::android.net.http.SslCertificate._m5) as java.util.Date;
		}
		public new global::java.lang.String ValidNotAfter
		{
			get
			{
				return getValidNotAfter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getValidNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;", ref global::android.net.http.SslCertificate._m6) as java.lang.String;
		}
		public new global::android.net.http.SslCertificate.DName IssuedTo
		{
			get
			{
				return getIssuedTo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.net.http.SslCertificate.DName getIssuedTo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;", ref global::android.net.http.SslCertificate._m7) as android.net.http.SslCertificate.DName;
		}
		public new global::android.net.http.SslCertificate.DName IssuedBy
		{
			get
			{
				return getIssuedBy();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.net.http.SslCertificate.DName getIssuedBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;", ref global::android.net.http.SslCertificate._m8) as android.net.http.SslCertificate.DName;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslCertificate._m9.native == global::System.IntPtr.Zero)
				global::android.net.http.SslCertificate._m9 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.util.Date arg2, java.util.Date arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslCertificate._m10.native == global::System.IntPtr.Zero)
				global::android.net.http.SslCertificate._m10 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public SslCertificate(java.security.cert.X509Certificate arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslCertificate._m11.native == global::System.IntPtr.Zero)
				global::android.net.http.SslCertificate._m11 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SslCertificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslCertificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate"));
		}
	}
}
