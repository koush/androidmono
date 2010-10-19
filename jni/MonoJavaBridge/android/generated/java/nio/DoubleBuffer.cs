namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.DoubleBuffer_))]
	public abstract partial class DoubleBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DoubleBuffer()
		{
			InitJNI();
		}
		protected DoubleBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16455;
		public abstract double get();
		internal static global::MonoJavaBridge.MethodId _get16456;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get16456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get16456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16457;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get16457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get16457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16458;
		public abstract double get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16459;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put16459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put16459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16460;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		internal static global::MonoJavaBridge.MethodId _put16461;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _put16462;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put16462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put16462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16463;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put16463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put16463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16464;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._equals16464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._equals16464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16465;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._toString16465)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._toString16465)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16466;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hashCode16466);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hashCode16466);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16467;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo16467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo16467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16468;
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo16468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo16468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16469;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16470;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hasArray16470);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hasArray16470);
		}
		internal static global::MonoJavaBridge.MethodId _array16471;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._array16471)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._array16471)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16472;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._arrayOffset16472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._arrayOffset16472);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16473;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap16473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16474;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap16474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16475;
		public static global::java.nio.DoubleBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._allocate16475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16476;
		public abstract global::java.nio.DoubleBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16477;
		public abstract global::java.nio.DoubleBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16478;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16479;
		public abstract global::java.nio.DoubleBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16480;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer._get16455 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer._get16456 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get16457 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get16458 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer._put16459 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put16460 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put16461 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put16462 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put16463 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._equals16464 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.DoubleBuffer._toString16465 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.DoubleBuffer._hashCode16466 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I");
			global::java.nio.DoubleBuffer._compareTo16467 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.DoubleBuffer._compareTo16468 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I");
			global::java.nio.DoubleBuffer._isDirect16469 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer._hasArray16470 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.DoubleBuffer._array16471 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.DoubleBuffer._arrayOffset16472 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.DoubleBuffer._wrap16473 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._wrap16474 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._allocate16475 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._duplicate16476 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._slice16477 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._asReadOnlyBuffer16478 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._compact16479 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._order16480 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.DoubleBuffer))]
	public sealed partial class DoubleBuffer_ : java.nio.DoubleBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DoubleBuffer_()
		{
			InitJNI();
		}
		internal DoubleBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16481;
		public override double get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get16481);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get16481);
		}
		internal static global::MonoJavaBridge.MethodId _get16482;
		public override double get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get16482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get16482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16483;
		public override global::java.nio.DoubleBuffer put(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put16483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put16483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16484;
		public override global::java.nio.DoubleBuffer put(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put16484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put16484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16485;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isDirect16485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isDirect16485);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16486;
		public override global::java.nio.DoubleBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._duplicate16486)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._duplicate16486)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16487;
		public override global::java.nio.DoubleBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._slice16487)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._slice16487)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16488;
		public override global::java.nio.DoubleBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._asReadOnlyBuffer16488)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._asReadOnlyBuffer16488)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16489;
		public override global::java.nio.DoubleBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._compact16489)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._compact16489)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16490;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._order16490)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._order16490)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16491;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isReadOnly16491);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isReadOnly16491);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer_._get16481 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer_._get16482 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer_._put16483 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._put16484 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._isDirect16485 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer_._duplicate16486 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._slice16487 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._asReadOnlyBuffer16488 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._compact16489 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._order16490 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.DoubleBuffer_._isReadOnly16491 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
