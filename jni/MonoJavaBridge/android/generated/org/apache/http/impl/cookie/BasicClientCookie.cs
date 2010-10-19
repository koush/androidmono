namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie : java.lang.Object, org.apache.http.cookie.SetCookie, org.apache.http.cookie.ClientCookie, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicClientCookie()
		{
			InitJNI();
		}
		protected BasicClientCookie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26474;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._toString26474)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._toString26474)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone26475;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._clone26475)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._clone26475)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName26476;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getName26476)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getName26476)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getValue26477;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getValue26477)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getValue26477)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue26478;
		public virtual void setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setValue26478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setValue26478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPath26479;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getPath26479)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getPath26479)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setComment26480;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setComment26480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setComment26480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getComment26481;
		public virtual global::java.lang.String getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getComment26481)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getComment26481)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute26482;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getAttribute26482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getAttribute26482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getVersion26483;
		public virtual int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getVersion26483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getVersion26483);
		}
		internal static global::MonoJavaBridge.MethodId _setVersion26484;
		public virtual void setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setVersion26484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setVersion26484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDomain26485;
		public virtual global::java.lang.String getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getDomain26485)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getDomain26485)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent26486;
		public virtual bool isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._isPersistent26486);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._isPersistent26486);
		}
		internal static global::MonoJavaBridge.MethodId _setPath26487;
		public virtual void setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setPath26487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setPath26487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute26488;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setAttribute26488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setAttribute26488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure26489;
		public virtual bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._isSecure26489);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._isSecure26489);
		}
		public new global::java.lang.String CommentURL
		{
			get
			{
				return getCommentURL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL26490;
		public virtual global::java.lang.String getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getCommentURL26490)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getCommentURL26490)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getExpiryDate26491;
		public virtual global::java.util.Date getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getExpiryDate26491)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getExpiryDate26491)) as java.util.Date;
		}
		public new int[] Ports
		{
			get
			{
				return getPorts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPorts26492;
		public virtual int[] getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._getPorts26492)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._getPorts26492)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired26493;
		public virtual bool isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._isExpired26493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._isExpired26493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute26494;
		public virtual bool containsAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._containsAttribute26494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._containsAttribute26494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate26495;
		public virtual void setExpiryDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setExpiryDate26495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setExpiryDate26495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain26496;
		public virtual void setDomain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setDomain26496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setDomain26496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure26497;
		public virtual void setSecure(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie._setSecure26497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._setSecure26497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicClientCookie26498;
		public BasicClientCookie(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._BasicClientCookie26498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie"));
			global::org.apache.http.impl.cookie.BasicClientCookie._toString26474 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._clone26475 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getName26476 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getValue26477 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._setValue26478 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._getPath26479 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._setComment26480 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._getComment26481 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getAttribute26482 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getVersion26483 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.BasicClientCookie._setVersion26484 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setVersion", "(I)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._getDomain26485 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._isPersistent26486 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isPersistent", "()Z");
			global::org.apache.http.impl.cookie.BasicClientCookie._setPath26487 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._setAttribute26488 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._isSecure26489 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.cookie.BasicClientCookie._getCommentURL26490 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getExpiryDate26491 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.impl.cookie.BasicClientCookie._getPorts26492 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPorts", "()[I");
			global::org.apache.http.impl.cookie.BasicClientCookie._isExpired26493 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isExpired", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.cookie.BasicClientCookie._containsAttribute26494 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "containsAttribute", "(Ljava/lang/String;)Z");
			global::org.apache.http.impl.cookie.BasicClientCookie._setExpiryDate26495 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._setDomain26496 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._setSecure26497 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.impl.cookie.BasicClientCookie._BasicClientCookie26498 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
