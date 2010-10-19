namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie2_))]
	public interface SetCookie2 : SetCookie
	{
		void setCommentURL(java.lang.String arg0);
		void setPorts(int[] arg0);
		void setDiscard(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SetCookie2))]
	public sealed partial class SetCookie2_ : java.lang.Object, SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SetCookie2_()
		{
			InitJNI();
		}
		internal SetCookie2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL25725;
		 void org.apache.http.cookie.SetCookie2.setCommentURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setCommentURL25725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setCommentURL25725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts25726;
		 void org.apache.http.cookie.SetCookie2.setPorts(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPorts25726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPorts25726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard25727;
		 void org.apache.http.cookie.SetCookie2.setDiscard(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDiscard25727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDiscard25727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValue25728;
		 void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setValue25728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setValue25728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment25729;
		 void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setComment25729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setComment25729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion25730;
		 void org.apache.http.cookie.SetCookie.setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setVersion25730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setVersion25730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath25731;
		 void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPath25731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPath25731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate25732;
		 void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setExpiryDate25732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setExpiryDate25732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain25733;
		 void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDomain25733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDomain25733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure25734;
		 void org.apache.http.cookie.SetCookie.setSecure(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setSecure25734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setSecure25734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName25735;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getName25735)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getName25735)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue25736;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getValue25736)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getValue25736)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath25737;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPath25737)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPath25737)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment25738;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getComment25738)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getComment25738)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion25739;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getVersion25739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getVersion25739);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain25740;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getDomain25740)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getDomain25740)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent25741;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isPersistent25741);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isPersistent25741);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25742;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isSecure25742);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isSecure25742);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL25743;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getCommentURL25743)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getCommentURL25743)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate25744;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getExpiryDate25744)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getExpiryDate25744)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts25745;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPorts25745)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPorts25745)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired25746;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isExpired25746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isExpired25746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie2"));
			global::org.apache.http.cookie.SetCookie2_._setCommentURL25725 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setPorts25726 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPorts", "([I)V");
			global::org.apache.http.cookie.SetCookie2_._setDiscard25727 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._setValue25728 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setComment25729 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setVersion25730 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie2_._setPath25731 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setExpiryDate25732 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie2_._setDomain25733 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setSecure25734 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._getName25735 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getValue25736 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getPath25737 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getComment25738 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getVersion25739 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie2_._getDomain25740 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._isPersistent25741 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie2_._isSecure25742 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie2_._getCommentURL25743 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getExpiryDate25744 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie2_._getPorts25745 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie2_._isExpired25746 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
