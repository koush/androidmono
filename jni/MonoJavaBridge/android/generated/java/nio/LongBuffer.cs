namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.LongBuffer_))]
	public abstract partial class LongBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LongBuffer()
		{
			InitJNI();
		}
		protected LongBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16567;
		public abstract long get();
		internal static global::MonoJavaBridge.MethodId _get16568;
		public virtual global::java.nio.LongBuffer get(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get16568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get16568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16569;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get16569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get16569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16570;
		public abstract long get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16571;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put16571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put16571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16572;
		public abstract global::java.nio.LongBuffer put(long arg0);
		internal static global::MonoJavaBridge.MethodId _put16573;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _put16574;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put16574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put16574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16575;
		public virtual global::java.nio.LongBuffer put(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put16575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put16575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16576;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._equals16576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._equals16576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16577;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._toString16577)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._toString16577)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16578;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._hashCode16578);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hashCode16578);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16579;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo16579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo16579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16580;
		public virtual int compareTo(java.nio.LongBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo16580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo16580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16581;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16582;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._hasArray16582);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hasArray16582);
		}
		internal static global::MonoJavaBridge.MethodId _array16583;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._array16583)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._array16583)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16584;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._arrayOffset16584);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._arrayOffset16584);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16585;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap16585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16586;
		public static global::java.nio.LongBuffer wrap(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap16586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16587;
		public static global::java.nio.LongBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._allocate16587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16588;
		public abstract global::java.nio.LongBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16589;
		public abstract global::java.nio.LongBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16590;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16591;
		public abstract global::java.nio.LongBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16592;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer._get16567 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "()J");
			global::java.nio.LongBuffer._get16568 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get16569 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get16570 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer._put16571 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put16572 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put16573 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put16574 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put16575 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._equals16576 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.LongBuffer._toString16577 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.LongBuffer._hashCode16578 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hashCode", "()I");
			global::java.nio.LongBuffer._compareTo16579 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.LongBuffer._compareTo16580 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I");
			global::java.nio.LongBuffer._isDirect16581 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer._hasArray16582 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.LongBuffer._array16583 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.LongBuffer._arrayOffset16584 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.LongBuffer._wrap16585 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._wrap16586 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._allocate16587 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._duplicate16588 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._slice16589 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._asReadOnlyBuffer16590 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._compact16591 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._order16592 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.LongBuffer))]
	public sealed partial class LongBuffer_ : java.nio.LongBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LongBuffer_()
		{
			InitJNI();
		}
		internal LongBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16593;
		public override long get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get16593);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get16593);
		}
		internal static global::MonoJavaBridge.MethodId _get16594;
		public override long get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get16594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get16594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16595;
		public override global::java.nio.LongBuffer put(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put16595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put16595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16596;
		public override global::java.nio.LongBuffer put(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put16596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put16596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16597;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isDirect16597);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isDirect16597);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16598;
		public override global::java.nio.LongBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._duplicate16598)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._duplicate16598)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16599;
		public override global::java.nio.LongBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._slice16599)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._slice16599)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16600;
		public override global::java.nio.LongBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._asReadOnlyBuffer16600)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._asReadOnlyBuffer16600)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16601;
		public override global::java.nio.LongBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._compact16601)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._compact16601)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16602;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._order16602)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._order16602)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16603;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isReadOnly16603);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isReadOnly16603);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer_._get16593 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "()J");
			global::java.nio.LongBuffer_._get16594 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer_._put16595 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._put16596 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._isDirect16597 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer_._duplicate16598 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._slice16599 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._asReadOnlyBuffer16600 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._compact16601 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._order16602 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.LongBuffer_._isReadOnly16603 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
