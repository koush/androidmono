namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributeListImpl : java.lang.Object, AttributeList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributeListImpl()
		{
			InitJNI();
		}
		protected AttributeListImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength28279;
		public virtual int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getLength28279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getLength28279);
		}
		internal static global::MonoJavaBridge.MethodId _clear28280;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._clear28280);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._clear28280);
		}
		internal static global::MonoJavaBridge.MethodId _getName28281;
		public virtual global::java.lang.String getName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getName28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getName28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28282;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getValue28282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getValue28282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28283;
		public virtual global::java.lang.String getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getValue28283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getValue28283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28284;
		public virtual global::java.lang.String getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getType28284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getType28284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28285;
		public virtual global::java.lang.String getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getType28285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getType28285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute28286;
		public virtual void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._addAttribute28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._addAttribute28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute28287;
		public virtual void removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._removeAttribute28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._removeAttribute28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeList28288;
		public virtual void setAttributeList(org.xml.sax.AttributeList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._setAttributeList28288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._setAttributeList28288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AttributeListImpl28289;
		public AttributeListImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl28289);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributeListImpl28290;
		public AttributeListImpl(org.xml.sax.AttributeList arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl28290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.AttributeListImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/AttributeListImpl"));
			global::org.xml.sax.helpers.AttributeListImpl._getLength28279 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getLength", "()I");
			global::org.xml.sax.helpers.AttributeListImpl._clear28280 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "clear", "()V");
			global::org.xml.sax.helpers.AttributeListImpl._getName28281 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getValue28282 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getValue28283 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getType28284 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getType28285 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._addAttribute28286 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributeListImpl._removeAttribute28287 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "removeAttribute", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributeListImpl._setAttributeList28288 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "setAttributeList", "(Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl28289 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl28290 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "<init>", "(Lorg/xml/sax/AttributeList;)V");
		}
	}
}
