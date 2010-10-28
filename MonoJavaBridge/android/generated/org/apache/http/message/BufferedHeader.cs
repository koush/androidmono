namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedHeader : java.lang.Object, FormattedHeader, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedHeader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33666;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._toString33666)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._toString33666)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33667;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._clone33667)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._clone33667)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33668;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._getName33668)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._getName33668)) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33669;
		public virtual global::java.lang.String getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._getValue33669)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._getValue33669)) as java.lang.String;
		}
		public new global::org.apache.http.HeaderElement[] Elements
		{
			get
			{
				return getElements();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElements33670;
		public virtual global::org.apache.http.HeaderElement[] getElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._getElements33670)) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._getElements33670)) as org.apache.http.HeaderElement[];
		}
		public new global::org.apache.http.util.CharArrayBuffer Buffer
		{
			get
			{
				return getBuffer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer33671;
		public virtual global::org.apache.http.util.CharArrayBuffer getBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._getBuffer33671)) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._getBuffer33671)) as org.apache.http.util.CharArrayBuffer;
		}
		public new int ValuePos
		{
			get
			{
				return getValuePos();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValuePos33672;
		public virtual int getValuePos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader._getValuePos33672);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._getValuePos33672);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedHeader33673;
		public BufferedHeader(org.apache.http.util.CharArrayBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._BufferedHeader33673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BufferedHeader.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BufferedHeader"));
			global::org.apache.http.message.BufferedHeader._toString33666 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BufferedHeader._clone33667 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BufferedHeader._getName33668 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.message.BufferedHeader._getValue33669 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.message.BufferedHeader._getElements33670 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BufferedHeader._getBuffer33671 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BufferedHeader._getValuePos33672 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "getValuePos", "()I");
			global::org.apache.http.message.BufferedHeader._BufferedHeader33673 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "<init>", "(Lorg/apache/http/util/CharArrayBuffer;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
