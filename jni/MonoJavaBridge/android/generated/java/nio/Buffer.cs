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
		internal static global::MonoJavaBridge.MethodId _limit16282;
		public virtual int limit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._limit16282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit16282);
		}
		internal static global::MonoJavaBridge.MethodId _limit16283;
		public virtual global::java.nio.Buffer limit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._limit16283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit16283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _clear16284;
		public virtual global::java.nio.Buffer clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._clear16284)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._clear16284)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _remaining16285;
		public virtual int remaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._remaining16285);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._remaining16285);
		}
		internal static global::MonoJavaBridge.MethodId _hasArray16286;
		public abstract bool hasArray();
		internal static global::MonoJavaBridge.MethodId _array16287;
		public abstract global::java.lang.Object array();
		internal static global::MonoJavaBridge.MethodId _position16288;
		public virtual global::java.nio.Buffer position(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._position16288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position16288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _position16289;
		public virtual int position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._position16289);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position16289);
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16290;
		public abstract int arrayOffset();
		internal static global::MonoJavaBridge.MethodId _capacity16291;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._capacity16291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._capacity16291);
		}
		internal static global::MonoJavaBridge.MethodId _mark16292;
		public virtual global::java.nio.Buffer mark() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._mark16292)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._mark16292)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _reset16293;
		public virtual global::java.nio.Buffer reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._reset16293)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._reset16293)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _flip16294;
		public virtual global::java.nio.Buffer flip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._flip16294)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._flip16294)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _rewind16295;
		public virtual global::java.nio.Buffer rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._rewind16295)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._rewind16295)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _hasRemaining16296;
		public virtual bool hasRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer._hasRemaining16296);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._hasRemaining16296);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16297;
		public abstract bool isReadOnly();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer._limit16282 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "()I");
			global::java.nio.Buffer._limit16283 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._clear16284 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._remaining16285 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "remaining", "()I");
			global::java.nio.Buffer._hasArray16286 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer._array16287 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer._position16288 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._position16289 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "()I");
			global::java.nio.Buffer._arrayOffset16290 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer._capacity16291 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "capacity", "()I");
			global::java.nio.Buffer._mark16292 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._reset16293 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._flip16294 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._rewind16295 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._hasRemaining16296 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
			global::java.nio.Buffer._isReadOnly16297 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "isReadOnly", "()Z");
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
		internal static global::MonoJavaBridge.MethodId _hasArray16298;
		public override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._hasArray16298);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._hasArray16298);
		}
		internal static global::MonoJavaBridge.MethodId _array16299;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer_._array16299)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._array16299)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16300;
		public override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer_._arrayOffset16300);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._arrayOffset16300);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16301;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._isReadOnly16301);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._isReadOnly16301);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer_._hasArray16298 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer_._array16299 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer_._arrayOffset16300 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer_._isReadOnly16301 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
