namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie2_))]
	public partial interface SetCookie2 : SetCookie
	{
		void setCommentURL(java.lang.String arg0);
		void setPorts(int[] arg0);
		void setDiscard(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SetCookie2))]
	internal sealed partial class SetCookie2_ : java.lang.Object, SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SetCookie2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.cookie.SetCookie2.setCommentURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setCommentURL", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie2_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.cookie.SetCookie2.setPorts(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setPorts", "([I)V", ref global::org.apache.http.cookie.SetCookie2_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.cookie.SetCookie2.setDiscard(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setDiscard", "(Z)V", ref global::org.apache.http.cookie.SetCookie2_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie2_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie2_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setVersion", "(I)V", ref global::org.apache.http.cookie.SetCookie2_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie2_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V", ref global::org.apache.http.cookie.SetCookie2_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setDomain", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie2_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "setSecure", "(Z)V", ref global::org.apache.http.cookie.SetCookie2_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.SetCookie2_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.SetCookie2_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.SetCookie2_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie2_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.SetCookie2_._m19) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.SetCookie2_._m20) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie2_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.SetCookie2_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SetCookie2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie2"));
		}
	}
}
