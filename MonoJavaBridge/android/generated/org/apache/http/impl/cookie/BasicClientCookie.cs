namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie : java.lang.Object, org.apache.http.cookie.SetCookie, org.apache.http.cookie.ClientCookie, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicClientCookie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m1) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m2) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
			set
			{
				setValue(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
			set
			{
				setPath(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
			set
			{
				setVersion(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getVersion", "()I", ref global::org.apache.http.impl.cookie.BasicClientCookie._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setVersion", "(I)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
			set
			{
				setDomain(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isPersistent", "()Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isSecure", "()Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._m15);
		}
		public new global::java.lang.String CommentURL
		{
			get
			{
				return getCommentURL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m16) as java.lang.String;
		}
		public new global::java.util.Date ExpiryDate
		{
			get
			{
				return getExpiryDate();
			}
			set
			{
				setExpiryDate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.util.Date getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.impl.cookie.BasicClientCookie._m17) as java.util.Date;
		}
		public new int[] Ports
		{
			get
			{
				return getPorts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int[] getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPorts", "()[I", ref global::org.apache.http.impl.cookie.BasicClientCookie._m18) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool containsAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "containsAttribute", "(Ljava/lang/String;)Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setExpiryDate", "(Ljava/util/Date;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setDomain", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Secure
		{
			set
			{
				setSecure(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setSecure(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setSecure", "(Z)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public BasicClientCookie(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicClientCookie._m24.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicClientCookie._m24 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicClientCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
