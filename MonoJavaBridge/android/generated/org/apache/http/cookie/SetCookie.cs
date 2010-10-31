namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie_))]
	public partial interface SetCookie : Cookie
	{
		void setValue(java.lang.String arg0);
		void setComment(java.lang.String arg0);
		void setVersion(int arg0);
		void setPath(java.lang.String arg0);
		void setExpiryDate(java.util.Date arg0);
		void setDomain(java.lang.String arg0);
		void setSecure(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SetCookie))]
	internal sealed partial class SetCookie_ : java.lang.Object, SetCookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SetCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setVersion", "(I)V", ref global::org.apache.http.cookie.SetCookie_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V", ref global::org.apache.http.cookie.SetCookie_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setDomain", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setSecure", "(Z)V", ref global::org.apache.http.cookie.SetCookie_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.SetCookie_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.SetCookie_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.SetCookie_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.SetCookie_._m16) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.SetCookie_._m17) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.SetCookie_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SetCookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie"));
		}
	}
}
