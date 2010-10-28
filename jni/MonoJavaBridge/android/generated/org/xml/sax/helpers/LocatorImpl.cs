namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocatorImpl : java.lang.Object, Locator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocatorImpl()
		{
			InitJNI();
		}
		protected LocatorImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35203;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203);
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
			set
			{
				setPublicId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35204;
		public virtual global::java.lang.String getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._getPublicId35204)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getPublicId35204)) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
			set
			{
				setSystemId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35205;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._getSystemId35205)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getSystemId35205)) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
			set
			{
				setColumnNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35206;
		public virtual int getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206);
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber35207;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId35208;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._setSystemId35208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setSystemId35208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId35209;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._setPublicId35209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setPublicId35209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnNumber35210;
		public virtual void setColumnNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LocatorImpl35211;
		public LocatorImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35211);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocatorImpl35212;
		public LocatorImpl(org.xml.sax.Locator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.LocatorImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/LocatorImpl"));
			global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.helpers.LocatorImpl._getPublicId35204 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.helpers.LocatorImpl._getSystemId35205 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getColumnNumber", "()I");
			global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setLineNumber", "(I)V");
			global::org.xml.sax.helpers.LocatorImpl._setSystemId35208 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.LocatorImpl._setPublicId35209 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setColumnNumber", "(I)V");
			global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35211 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35212 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "(Lorg/xml/sax/Locator;)V");
		}
	}
}
