namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributesImpl : java.lang.Object, Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getLength35161;
		public virtual int getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getLength35161);
		}
		internal static global::MonoJavaBridge.MethodId _clear35162;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._clear35162);
		}
		internal static global::MonoJavaBridge.MethodId _getValue35163;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue35163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35164;
		public virtual global::java.lang.String getValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue35164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35165;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getValue35165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35166;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType35166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35167;
		public virtual global::java.lang.String getType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType35167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35168;
		public virtual global::java.lang.String getType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getType35168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue35169;
		public virtual void setValue(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setValue35169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35170;
		public virtual int getIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getIndex35170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35171;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getIndex35171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute35172;
		public virtual void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._addAttribute35172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getQName35173;
		public virtual global::java.lang.String getQName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getQName35173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName35174;
		public virtual global::java.lang.String getLocalName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getLocalName35174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35175;
		public virtual global::java.lang.String getURI(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._getURI35175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute35176;
		public virtual void removeAttribute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._removeAttribute35176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setType35177;
		public virtual void setType(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setType35177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Attributes Attributes
		{
			set
			{
				setAttributes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes35178;
		public virtual void setAttributes(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setAttributes35178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute35179;
		public virtual void setAttribute(int arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setAttribute35179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setURI35180;
		public virtual void setURI(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setURI35180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocalName35181;
		public virtual void setLocalName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setLocalName35181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQName35182;
		public virtual void setQName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._setQName35182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AttributesImpl35183;
		public AttributesImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._AttributesImpl35183);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributesImpl35184;
		public AttributesImpl(org.xml.sax.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._AttributesImpl35184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AttributesImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.AttributesImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/AttributesImpl"));
			global::org.xml.sax.helpers.AttributesImpl._getLength35161 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLength", "()I");
			global::org.xml.sax.helpers.AttributesImpl._clear35162 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "clear", "()V");
			global::org.xml.sax.helpers.AttributesImpl._getValue35163 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getValue35164 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getValue35165 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType35166 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType35167 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getType35168 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._setValue35169 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setValue", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._getIndex35170 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.helpers.AttributesImpl._getIndex35171 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.helpers.AttributesImpl._addAttribute35172 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._getQName35173 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getLocalName35174 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._getURI35175 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "getURI", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributesImpl._removeAttribute35176 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "removeAttribute", "(I)V");
			global::org.xml.sax.helpers.AttributesImpl._setType35177 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setType", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setAttributes35178 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.AttributesImpl._setAttribute35179 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setURI35180 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setURI", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setLocalName35181 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setLocalName", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._setQName35182 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "setQName", "(ILjava/lang/String;)V");
			global::org.xml.sax.helpers.AttributesImpl._AttributesImpl35183 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.AttributesImpl._AttributesImpl35184 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
