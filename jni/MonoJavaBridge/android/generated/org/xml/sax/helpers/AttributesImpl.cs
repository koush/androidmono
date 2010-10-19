namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributesImpl : java.lang.Object, Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributesImpl()
		{
			InitJNI();
		}
		protected AttributesImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength28291;
		public virtual int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getLength28291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getLength28291);
		}
		internal static global::MonoJavaBridge.MethodId _clear28292;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._clear28292);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._clear28292);
		}
		internal static global::MonoJavaBridge.MethodId _getValue28293;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getValue28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28294;
		public virtual global::java.lang.String getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getValue28294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue28294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28295;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getValue28295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue28295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28296;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getType28296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType28296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28297;
		public virtual global::java.lang.String getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getType28297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType28297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28298;
		public virtual global::java.lang.String getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getType28298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType28298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue28299;
		public virtual void setValue(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setValue28299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setValue28299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28300;
		public virtual int getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getIndex28300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getIndex28300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28301;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getIndex28301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getIndex28301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute28302;
		public virtual void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._addAttribute28302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._addAttribute28302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getQName28303;
		public virtual global::java.lang.String getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getQName28303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getQName28303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName28304;
		public virtual global::java.lang.String getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getLocalName28304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getLocalName28304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI28305;
		public virtual global::java.lang.String getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._getURI28305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getURI28305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute28306;
		public virtual void removeAttribute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._removeAttribute28306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._removeAttribute28306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setType28307;
		public virtual void setType(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setType28307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setType28307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes28308;
		public virtual void setAttributes(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setAttributes28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setAttributes28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute28309;
		public virtual void setAttribute(int arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setAttribute28309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setAttribute28309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setURI28310;
		public virtual void setURI(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setURI28310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setURI28310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocalName28311;
		public virtual void setLocalName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setLocalName28311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setLocalName28311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQName28312;
		public virtual void setQName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl._setQName28312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setQName28312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AttributesImpl28313;
		public AttributesImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._AttributesImpl28313);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributesImpl28314;
		public AttributesImpl(org.xml.sax.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._AttributesImpl28314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.AttributesImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/AttributesImpl"));
			global::org.xml.sax.helpers.AttributesImpl._getLength28291 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLength", "()I");
			global::org.xml.sax.helpers.AttributesImpl._clear28292 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "clear", "()V");
			global::org.xml.sax.helpers.AttributesImpl._getValue28293 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getValue28294 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getValue28295 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType28296 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType28297 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType28298 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._setValue28299 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setValue", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._getIndex28300 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.helpers.AttributesImpl._getIndex28301 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.helpers.AttributesImpl._addAttribute28302 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._getQName28303 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getLocalName28304 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getURI28305 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getURI", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._removeAttribute28306 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "removeAttribute", "(I)V");
			global::org.xml.sax.helpers.AttributesImpl._setType28307 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setType", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setAttributes28308 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.AttributesImpl._setAttribute28309 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setURI28310 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setURI", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setLocalName28311 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setLocalName", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setQName28312 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setQName", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._AttributesImpl28313 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.AttributesImpl._AttributesImpl28314 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
		}
	}
}
