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
		internal static global::MonoJavaBridge.MethodId _limit13980;
		public virtual int limit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._limit13980);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit13980);
		}
		internal static global::MonoJavaBridge.MethodId _limit13981;
		public virtual global::java.nio.Buffer limit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._limit13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _clear13982;
		public virtual global::java.nio.Buffer clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._clear13982)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._clear13982)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _remaining13983;
		public virtual int remaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._remaining13983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._remaining13983);
		}
		internal static global::MonoJavaBridge.MethodId _hasArray13984;
		public abstract bool hasArray();
		internal static global::MonoJavaBridge.MethodId _array13985;
		public abstract global::java.lang.Object array();
		internal static global::MonoJavaBridge.MethodId _position13986;
		public virtual global::java.nio.Buffer position(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._position13986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position13986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _position13987;
		public virtual int position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._position13987);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position13987);
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset13988;
		public abstract int arrayOffset();
		internal static global::MonoJavaBridge.MethodId _capacity13989;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._capacity13989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._capacity13989);
		}
		internal static global::MonoJavaBridge.MethodId _mark13990;
		public virtual global::java.nio.Buffer mark() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._mark13990)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._mark13990)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _reset13991;
		public virtual global::java.nio.Buffer reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._reset13991)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._reset13991)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _flip13992;
		public virtual global::java.nio.Buffer flip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._flip13992)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._flip13992)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _rewind13993;
		public virtual global::java.nio.Buffer rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._rewind13993)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._rewind13993)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _hasRemaining13994;
		public virtual bool hasRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer._hasRemaining13994);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._hasRemaining13994);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly13995;
		public abstract bool isReadOnly();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer._limit13980 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "()I");
			global::java.nio.Buffer._limit13981 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._clear13982 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._remaining13983 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "remaining", "()I");
			global::java.nio.Buffer._hasArray13984 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer._array13985 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer._position13986 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._position13987 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "()I");
			global::java.nio.Buffer._arrayOffset13988 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer._capacity13989 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "capacity", "()I");
			global::java.nio.Buffer._mark13990 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._reset13991 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._flip13992 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._rewind13993 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._hasRemaining13994 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
			global::java.nio.Buffer._isReadOnly13995 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "isReadOnly", "()Z");
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
		internal static global::MonoJavaBridge.MethodId _hasArray13996;
		public override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._hasArray13996);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._hasArray13996);
		}
		internal static global::MonoJavaBridge.MethodId _array13997;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer_._array13997)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._array13997)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset13998;
		public override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer_._arrayOffset13998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._arrayOffset13998);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly13999;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._isReadOnly13999);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._isReadOnly13999);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer_._hasArray13996 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer_._array13997 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer_._arrayOffset13998 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer_._isReadOnly13999 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
