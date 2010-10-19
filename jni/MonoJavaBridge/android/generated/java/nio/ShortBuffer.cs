namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ShortBuffer_))]
	public abstract partial class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBuffer()
		{
			InitJNI();
		}
		protected ShortBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16648;
		public abstract short get();
		internal static global::MonoJavaBridge.MethodId _get16649;
		public virtual global::java.nio.ShortBuffer get(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get16649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get16649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16650;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get16650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get16650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16651;
		public abstract short get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16652;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put16652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put16652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16653;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		internal static global::MonoJavaBridge.MethodId _put16654;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _put16655;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put16655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put16655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16656;
		public virtual global::java.nio.ShortBuffer put(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put16656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put16656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16657;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._equals16657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._equals16657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16658;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._toString16658)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._toString16658)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16659;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._hashCode16659);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hashCode16659);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16660;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo16660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo16660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16661;
		public virtual int compareTo(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo16661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo16661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16662;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16663;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._hasArray16663);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hasArray16663);
		}
		internal static global::MonoJavaBridge.MethodId _array16664;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._array16664)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._array16664)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16665;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._arrayOffset16665);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._arrayOffset16665);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16666;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap16666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16667;
		public static global::java.nio.ShortBuffer wrap(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap16667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16668;
		public static global::java.nio.ShortBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate16668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16669;
		public abstract global::java.nio.ShortBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16670;
		public abstract global::java.nio.ShortBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16671;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16672;
		public abstract global::java.nio.ShortBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16673;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer._get16648 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "()S");
			global::java.nio.ShortBuffer._get16649 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get16650 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get16651 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer._put16652 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put16653 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put16654 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put16655 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put16656 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._equals16657 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ShortBuffer._toString16658 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ShortBuffer._hashCode16659 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ShortBuffer._compareTo16660 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ShortBuffer._compareTo16661 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I");
			global::java.nio.ShortBuffer._isDirect16662 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer._hasArray16663 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ShortBuffer._array16664 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ShortBuffer._arrayOffset16665 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ShortBuffer._wrap16666 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._wrap16667 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._allocate16668 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._duplicate16669 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._slice16670 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._asReadOnlyBuffer16671 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._compact16672 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._order16673 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ShortBuffer))]
	public sealed partial class ShortBuffer_ : java.nio.ShortBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBuffer_()
		{
			InitJNI();
		}
		internal ShortBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16674;
		public override short get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get16674);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get16674);
		}
		internal static global::MonoJavaBridge.MethodId _get16675;
		public override short get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get16675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get16675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16676;
		public override global::java.nio.ShortBuffer put(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put16676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put16676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16677;
		public override global::java.nio.ShortBuffer put(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put16677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put16677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16678;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isDirect16678);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isDirect16678);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16679;
		public override global::java.nio.ShortBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._duplicate16679)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._duplicate16679)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16680;
		public override global::java.nio.ShortBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._slice16680)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._slice16680)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16681;
		public override global::java.nio.ShortBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._asReadOnlyBuffer16681)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._asReadOnlyBuffer16681)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16682;
		public override global::java.nio.ShortBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._compact16682)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._compact16682)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16683;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._order16683)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._order16683)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16684;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isReadOnly16684);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isReadOnly16684);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer_._get16674 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "()S");
			global::java.nio.ShortBuffer_._get16675 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer_._put16676 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._put16677 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._isDirect16678 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer_._duplicate16679 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._slice16680 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._asReadOnlyBuffer16681 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._compact16682 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._order16683 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ShortBuffer_._isReadOnly16684 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
