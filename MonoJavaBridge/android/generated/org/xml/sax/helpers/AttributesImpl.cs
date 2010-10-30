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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLength", "()I", ref global::org.xml.sax.helpers.AttributesImpl._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "clear", "()V", ref global::org.xml.sax.helpers.AttributesImpl._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(I)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(I)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setValue(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setValue", "(ILjava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;)I", ref global::org.xml.sax.helpers.AttributesImpl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::org.xml.sax.helpers.AttributesImpl._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String getQName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getQName", "(I)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getLocalName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getLocalName", "(I)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getURI(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "getURI", "(I)Ljava/lang/String;", ref global::org.xml.sax.helpers.AttributesImpl._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void removeAttribute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "removeAttribute", "(I)V", ref global::org.xml.sax.helpers.AttributesImpl._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setType(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setType", "(ILjava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Attributes Attributes
		{
			set
			{
				setAttributes(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setAttributes(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V", ref global::org.xml.sax.helpers.AttributesImpl._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setAttribute(int arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setURI(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setURI", "(ILjava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setLocalName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setLocalName", "(ILjava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setQName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.AttributesImpl.staticClass, "setQName", "(ILjava/lang/String;)V", ref global::org.xml.sax.helpers.AttributesImpl._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public AttributesImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.AttributesImpl._m22.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.AttributesImpl._m22 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._m22);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public AttributesImpl(org.xml.sax.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.AttributesImpl._m23.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.AttributesImpl._m23 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributesImpl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributesImpl.staticClass, global::org.xml.sax.helpers.AttributesImpl._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AttributesImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.AttributesImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/AttributesImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
