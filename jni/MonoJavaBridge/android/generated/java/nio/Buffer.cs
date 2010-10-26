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
		internal static global::MonoJavaBridge.MethodId _limit21994;
		public virtual int limit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._limit21994);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21994);
		}
		internal static global::MonoJavaBridge.MethodId _limit21995;
		public virtual global::java.nio.Buffer limit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._limit21995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _clear21996;
		public virtual global::java.nio.Buffer clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._clear21996)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._clear21996)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _remaining21997;
		public virtual int remaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._remaining21997);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._remaining21997);
		}
		internal static global::MonoJavaBridge.MethodId _hasArray21998;
		public abstract bool hasArray();
		internal static global::MonoJavaBridge.MethodId _array21999;
		public abstract global::java.lang.Object array();
		internal static global::MonoJavaBridge.MethodId _position22000;
		public virtual global::java.nio.Buffer position(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._position22000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position22000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _position22001;
		public virtual int position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._position22001);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position22001);
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22002;
		public abstract int arrayOffset();
		internal static global::MonoJavaBridge.MethodId _capacity22003;
		public virtual int capacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer._capacity22003);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._capacity22003);
		}
		internal static global::MonoJavaBridge.MethodId _mark22004;
		public virtual global::java.nio.Buffer mark() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._mark22004)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._mark22004)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _reset22005;
		public virtual global::java.nio.Buffer reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._reset22005)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._reset22005)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _flip22006;
		public virtual global::java.nio.Buffer flip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._flip22006)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._flip22006)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _rewind22007;
		public virtual global::java.nio.Buffer rewind() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer._rewind22007)) as java.nio.Buffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._rewind22007)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _hasRemaining22008;
		public virtual bool hasRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer._hasRemaining22008);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._hasRemaining22008);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22009;
		public abstract bool isReadOnly();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer._limit21994 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "()I");
			global::java.nio.Buffer._limit21995 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._clear21996 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._remaining21997 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "remaining", "()I");
			global::java.nio.Buffer._hasArray21998 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer._array21999 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer._position22000 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
			global::java.nio.Buffer._position22001 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "()I");
			global::java.nio.Buffer._arrayOffset22002 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer._capacity22003 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "capacity", "()I");
			global::java.nio.Buffer._mark22004 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._reset22005 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._flip22006 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._rewind22007 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
			global::java.nio.Buffer._hasRemaining22008 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
			global::java.nio.Buffer._isReadOnly22009 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "isReadOnly", "()Z");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.Buffer))]
	internal sealed partial class Buffer_ : java.nio.Buffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Buffer_()
		{
			InitJNI();
		}
		internal Buffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasArray22010;
		public override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._hasArray22010);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._hasArray22010);
		}
		internal static global::MonoJavaBridge.MethodId _array22011;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer_._array22011)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._array22011)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22012;
		public override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer_._arrayOffset22012);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._arrayOffset22012);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22013;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._isReadOnly22013);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.Buffer_.staticClass, global::java.nio.Buffer_._isReadOnly22013);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
			global::java.nio.Buffer_._hasArray22010 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "hasArray", "()Z");
			global::java.nio.Buffer_._array22011 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.Buffer_._arrayOffset22012 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "arrayOffset", "()I");
			global::java.nio.Buffer_._isReadOnly22013 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
