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
			internal static global::MonoJavaBridge.MethodId _getDName7944;
			public virtual global::java.lang.String getDName()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getDName7944)) as java.lang.String;
			}
			public new global::java.lang.String CName
			{
				get
				{
					return getCName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCName7945;
			public virtual global::java.lang.String getCName()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getCName7945)) as java.lang.String;
			}
			public new global::java.lang.String OName
			{
				get
				{
					return getOName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getOName7946;
			public virtual global::java.lang.String getOName()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getOName7946)) as java.lang.String;
			}
			public new global::java.lang.String UName
			{
				get
				{
					return getUName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getUName7947;
			public virtual global::java.lang.String getUName()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getUName7947)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _DName7948;
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._DName7948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static DName()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.http.SslCertificate.DName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate$DName"));
				global::android.net.http.SslCertificate.DName._getDName7944 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getCName7945 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getOName7946 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getUName7947 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._DName7948 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString7949;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._toString7949)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState7950;
		public static global::android.os.Bundle saveState(android.net.http.SslCertificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._saveState7950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState7951;
		public static global::android.net.http.SslCertificate restoreState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._restoreState7951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.SslCertificate;
		}
		public new global::java.util.Date ValidNotBeforeDate
		{
			get
			{
				return getValidNotBeforeDate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBeforeDate7952;
		public virtual global::java.util.Date getValidNotBeforeDate()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBeforeDate7952)) as java.util.Date;
		}
		public new global::java.lang.String ValidNotBefore
		{
			get
			{
				return getValidNotBefore();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBefore7953;
		public virtual global::java.lang.String getValidNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBefore7953)) as java.lang.String;
		}
		public new global::java.util.Date ValidNotAfterDate
		{
			get
			{
				return getValidNotAfterDate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfterDate7954;
		public virtual global::java.util.Date getValidNotAfterDate()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfterDate7954)) as java.util.Date;
		}
		public new global::java.lang.String ValidNotAfter
		{
			get
			{
				return getValidNotAfter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfter7955;
		public virtual global::java.lang.String getValidNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfter7955)) as java.lang.String;
		}
		public new global::android.net.http.SslCertificate.DName IssuedTo
		{
			get
			{
				return getIssuedTo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedTo7956;
		public virtual global::android.net.http.SslCertificate.DName getIssuedTo()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedTo7956)) as android.net.http.SslCertificate.DName;
		}
		public new global::android.net.http.SslCertificate.DName IssuedBy
		{
			get
			{
				return getIssuedBy();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedBy7957;
		public virtual global::android.net.http.SslCertificate.DName getIssuedBy()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedBy7957)) as android.net.http.SslCertificate.DName;
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7958;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7959;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.util.Date arg2, java.util.Date arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7960;
		public SslCertificate(java.security.cert.X509Certificate arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SslCertificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslCertificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate"));
			global::android.net.http.SslCertificate._toString7949 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._saveState7950 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;");
			global::android.net.http.SslCertificate._restoreState7951 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;");
			global::android.net.http.SslCertificate._getValidNotBeforeDate7952 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBeforeDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotBefore7953 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getValidNotAfterDate7954 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfterDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotAfter7955 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getIssuedTo7956 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._getIssuedBy7957 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._SslCertificate7958 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.http.SslCertificate._SslCertificate7959 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)V");
			global::android.net.http.SslCertificate._SslCertificate7960 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
