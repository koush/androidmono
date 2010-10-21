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
			internal static global::MonoJavaBridge.MethodId _getDName7904;
			public virtual global::java.lang.String getDName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getDName7904)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getDName7904)) as java.lang.String;
			}
			public new global::java.lang.String CName
			{
				get
				{
					return getCName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCName7905;
			public virtual global::java.lang.String getCName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getCName7905)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getCName7905)) as java.lang.String;
			}
			public new global::java.lang.String OName
			{
				get
				{
					return getOName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getOName7906;
			public virtual global::java.lang.String getOName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getOName7906)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getOName7906)) as java.lang.String;
			}
			public new global::java.lang.String UName
			{
				get
				{
					return getUName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getUName7907;
			public virtual global::java.lang.String getUName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName._getUName7907)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getUName7907)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _DName7908;
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._DName7908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.http.SslCertificate.DName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate$DName"));
				global::android.net.http.SslCertificate.DName._getDName7904 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getCName7905 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getOName7906 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._getUName7907 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;");
				global::android.net.http.SslCertificate.DName._DName7908 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString7909;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._toString7909)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._toString7909)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState7910;
		public static global::android.os.Bundle saveState(android.net.http.SslCertificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._saveState7910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState7911;
		public static global::android.net.http.SslCertificate restoreState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._restoreState7911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.http.SslCertificate;
		}
		public new global::java.util.Date ValidNotBeforeDate
		{
			get
			{
				return getValidNotBeforeDate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBeforeDate7912;
		public virtual global::java.util.Date getValidNotBeforeDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotBeforeDate7912)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBeforeDate7912)) as java.util.Date;
		}
		public new global::java.lang.String ValidNotBefore
		{
			get
			{
				return getValidNotBefore();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotBefore7913;
		public virtual global::java.lang.String getValidNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotBefore7913)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBefore7913)) as java.lang.String;
		}
		public new global::java.util.Date ValidNotAfterDate
		{
			get
			{
				return getValidNotAfterDate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfterDate7914;
		public virtual global::java.util.Date getValidNotAfterDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotAfterDate7914)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfterDate7914)) as java.util.Date;
		}
		public new global::java.lang.String ValidNotAfter
		{
			get
			{
				return getValidNotAfter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValidNotAfter7915;
		public virtual global::java.lang.String getValidNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getValidNotAfter7915)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfter7915)) as java.lang.String;
		}
		public new global::android.net.http.SslCertificate.DName IssuedTo
		{
			get
			{
				return getIssuedTo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedTo7916;
		public virtual global::android.net.http.SslCertificate.DName getIssuedTo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getIssuedTo7916)) as android.net.http.SslCertificate.DName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedTo7916)) as android.net.http.SslCertificate.DName;
		}
		public new global::android.net.http.SslCertificate.DName IssuedBy
		{
			get
			{
				return getIssuedBy();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuedBy7917;
		public virtual global::android.net.http.SslCertificate.DName getIssuedBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate._getIssuedBy7917)) as android.net.http.SslCertificate.DName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedBy7917)) as android.net.http.SslCertificate.DName;
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7918;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7919;
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.util.Date arg2, java.util.Date arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslCertificate7920;
		public SslCertificate(java.security.cert.X509Certificate arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate7920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslCertificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslCertificate"));
			global::android.net.http.SslCertificate._toString7909 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._saveState7910 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;");
			global::android.net.http.SslCertificate._restoreState7911 = @__env.GetStaticMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;");
			global::android.net.http.SslCertificate._getValidNotBeforeDate7912 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBeforeDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotBefore7913 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getValidNotAfterDate7914 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfterDate", "()Ljava/util/Date;");
			global::android.net.http.SslCertificate._getValidNotAfter7915 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;");
			global::android.net.http.SslCertificate._getIssuedTo7916 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._getIssuedBy7917 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;");
			global::android.net.http.SslCertificate._SslCertificate7918 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.http.SslCertificate._SslCertificate7919 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)V");
			global::android.net.http.SslCertificate._SslCertificate7920 = @__env.GetMethodIDNoThrow(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V");
		}
	}
}
