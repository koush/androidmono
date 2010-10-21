namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.Buffer_))]
	public abstract partial class Buffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Buffer()
		{
			InitJNI();
		}
		protected Buffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _limit21876;
		public virtual int limit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._limit21876);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21876);
		}
		internal static global::MonoJavaBridge.MethodId _limit21877;
		public virtual global::java.nio.Buffer limit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._limit21877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _clear21878;
		public virtual global::java.nio.Buffer clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._clear21878)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._clear21878)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _remaining21879;
		public virtual int remaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._remaining21879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._remaining21879);
		}
		internal static global::MonoJavaBridge.MethodId _hasArray21880;
		public abstract bool hasArray();
		internal static global::MonoJavaBridge.MethodId _array21881;
		public abstract global::java.lang.Object array();
		internal static global::MonoJavaBridge.MethodId _position21882;
		public virtual global::java.nio.Buffer position(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._position21882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position21882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _position21883;
		public virtual int position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._position21883);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position21883);
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset21884;
		public abstract int arrayOffset();
		internal static global::MonoJavaBridge.MethodId _capacity21885;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._capacity21885);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._capacity21885);
		}
		internal static global::MonoJavaBridge.MethodId _mark21886;
		public virtual global::java.nio.Buffer mark() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._mark21886)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._mark21886)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _reset21887;
		public virtual global::java.nio.Buffer reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._reset21887)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._reset21887)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _flip21888;
		public virtual global::java.nio.Buffer flip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._flip21888)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._flip21888)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _rewind21889;
		public virtual global::java.nio.Buffer rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._rewind21889)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._rewind21889)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _hasRemaining21890;
		public virtual bool hasRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer._hasRemaining21890);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._hasRemaining21890);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly21891;
		public abstract bool isReadOnly();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer._limit21876 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "()I");
			global::java.nio.Buffer._limit21877 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._clear21878 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._remaining21879 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "remaining", "()I");
			global::java.nio.Buffer._hasArray21880 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer._array21881 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer._position21882 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._position21883 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "()I");
			global::java.nio.Buffer._arrayOffset21884 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer._capacity21885 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "capacity", "()I");
			global::java.nio.Buffer._mark21886 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._reset21887 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._flip21888 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._rewind21889 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._hasRemaining21890 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
			global::java.nio.Buffer._isReadOnly21891 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "isReadOnly", "()Z");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.Buffer))]
	public sealed partial class Buffer_ : java.nio.Buffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Buffer_()
		{
			InitJNI();
		}
		internal Buffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasArray21892;
		public override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._hasArray21892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._hasArray21892);
		}
		internal static global::MonoJavaBridge.MethodId _array21893;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer_._array21893)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._array21893)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset21894;
		public override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer_._arrayOffset21894);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._arrayOffset21894);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly21895;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._isReadOnly21895);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._isReadOnly21895);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer_._hasArray21892 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer_._array21893 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer_._arrayOffset21894 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer_._isReadOnly21895 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
