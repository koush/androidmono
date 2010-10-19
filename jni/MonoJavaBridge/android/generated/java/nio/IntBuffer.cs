namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.IntBuffer_))]
	public abstract partial class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntBuffer()
		{
			InitJNI();
		}
		protected IntBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16529;
		public abstract int get();
		internal static global::MonoJavaBridge.MethodId _get16530;
		public virtual global::java.nio.IntBuffer get(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get16530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get16530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16531;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get16531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get16531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16532;
		public abstract int get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16533;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put16533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put16533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16534;
		public abstract global::java.nio.IntBuffer put(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16535;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _put16536;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put16536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put16536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16537;
		public virtual global::java.nio.IntBuffer put(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put16537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put16537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16538;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._equals16538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals16538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16539;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._toString16539)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString16539)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16540;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._hashCode16540);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode16540);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16541;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo16541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo16541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16542;
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo16542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo16542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16543;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16544;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._hasArray16544);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hasArray16544);
		}
		internal static global::MonoJavaBridge.MethodId _array16545;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._array16545)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._array16545)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16546;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._arrayOffset16546);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._arrayOffset16546);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16547;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap16547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16548;
		public static global::java.nio.IntBuffer wrap(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap16548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16549;
		public static global::java.nio.IntBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate16549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16550;
		public abstract global::java.nio.IntBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16551;
		public abstract global::java.nio.IntBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16552;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16553;
		public abstract global::java.nio.IntBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16554;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer._get16529 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "()I");
			global::java.nio.IntBuffer._get16530 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get16531 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get16532 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer._put16533 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put16534 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put16535 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put16536 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put16537 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._equals16538 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.IntBuffer._toString16539 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.IntBuffer._hashCode16540 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hashCode", "()I");
			global::java.nio.IntBuffer._compareTo16541 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.IntBuffer._compareTo16542 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I");
			global::java.nio.IntBuffer._isDirect16543 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer._hasArray16544 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.IntBuffer._array16545 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.IntBuffer._arrayOffset16546 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.IntBuffer._wrap16547 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._wrap16548 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._allocate16549 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._duplicate16550 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._slice16551 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._asReadOnlyBuffer16552 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._compact16553 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._order16554 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.IntBuffer))]
	public sealed partial class IntBuffer_ : java.nio.IntBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntBuffer_()
		{
			InitJNI();
		}
		internal IntBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16555;
		public override int get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get16555);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get16555);
		}
		internal static global::MonoJavaBridge.MethodId _get16556;
		public override int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get16556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get16556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16557;
		public override global::java.nio.IntBuffer put(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put16557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put16557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16558;
		public override global::java.nio.IntBuffer put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put16558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put16558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16559;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isDirect16559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isDirect16559);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16560;
		public override global::java.nio.IntBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._duplicate16560)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._duplicate16560)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16561;
		public override global::java.nio.IntBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._slice16561)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._slice16561)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16562;
		public override global::java.nio.IntBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._asReadOnlyBuffer16562)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._asReadOnlyBuffer16562)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16563;
		public override global::java.nio.IntBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._compact16563)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._compact16563)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16564;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._order16564)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._order16564)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16565;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isReadOnly16565);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isReadOnly16565);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer_._get16555 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "()I");
			global::java.nio.IntBuffer_._get16556 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer_._put16557 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._put16558 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._isDirect16559 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer_._duplicate16560 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._slice16561 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._asReadOnlyBuffer16562 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._compact16563 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._order16564 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.IntBuffer_._isReadOnly16565 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
