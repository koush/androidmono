namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.FloatBuffer_))]
	public abstract partial class FloatBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FloatBuffer()
		{
			InitJNI();
		}
		protected FloatBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16492;
		public abstract float get();
		internal static global::MonoJavaBridge.MethodId _get16493;
		public virtual global::java.nio.FloatBuffer get(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16494;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get16494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get16494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get16495;
		public abstract float get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put16496;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16497;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		internal static global::MonoJavaBridge.MethodId _put16498;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _put16499;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put16499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put16499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16500;
		public virtual global::java.nio.FloatBuffer put(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put16500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put16500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals16501;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._equals16501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals16501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16502;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._toString16502)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString16502)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16503;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._hashCode16503);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode16503);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16504;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo16504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo16504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo16505;
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo16505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo16505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16506;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray16507;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._hasArray16507);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hasArray16507);
		}
		internal static global::MonoJavaBridge.MethodId _array16508;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._array16508)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._array16508)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset16509;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._arrayOffset16509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._arrayOffset16509);
		}
		internal static global::MonoJavaBridge.MethodId _wrap16510;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap16510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap16511;
		public static global::java.nio.FloatBuffer wrap(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap16511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate16512;
		public static global::java.nio.FloatBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate16512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16513;
		public abstract global::java.nio.FloatBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice16514;
		public abstract global::java.nio.FloatBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16515;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact16516;
		public abstract global::java.nio.FloatBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order16517;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer._get16492 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "()F");
			global::java.nio.FloatBuffer._get16493 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get16494 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get16495 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer._put16496 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put16497 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put16498 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put16499 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put16500 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._equals16501 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.FloatBuffer._toString16502 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.FloatBuffer._hashCode16503 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I");
			global::java.nio.FloatBuffer._compareTo16504 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.FloatBuffer._compareTo16505 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I");
			global::java.nio.FloatBuffer._isDirect16506 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer._hasArray16507 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.FloatBuffer._array16508 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.FloatBuffer._arrayOffset16509 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.FloatBuffer._wrap16510 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._wrap16511 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._allocate16512 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._duplicate16513 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._slice16514 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._asReadOnlyBuffer16515 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._compact16516 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._order16517 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.FloatBuffer))]
	public sealed partial class FloatBuffer_ : java.nio.FloatBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FloatBuffer_()
		{
			InitJNI();
		}
		internal FloatBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16518;
		public override float get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get16518);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get16518);
		}
		internal static global::MonoJavaBridge.MethodId _get16519;
		public override float get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get16519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get16519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put16520;
		public override global::java.nio.FloatBuffer put(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put16520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put16520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put16521;
		public override global::java.nio.FloatBuffer put(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put16521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put16521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect16522;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isDirect16522);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isDirect16522);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate16523;
		public override global::java.nio.FloatBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._duplicate16523)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._duplicate16523)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice16524;
		public override global::java.nio.FloatBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._slice16524)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._slice16524)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer16525;
		public override global::java.nio.FloatBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._asReadOnlyBuffer16525)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._asReadOnlyBuffer16525)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact16526;
		public override global::java.nio.FloatBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._compact16526)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._compact16526)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order16527;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._order16527)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._order16527)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly16528;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isReadOnly16528);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isReadOnly16528);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer_._get16518 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "()F");
			global::java.nio.FloatBuffer_._get16519 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer_._put16520 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._put16521 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._isDirect16522 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer_._duplicate16523 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._slice16524 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._asReadOnlyBuffer16525 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._compact16526 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._order16527 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.FloatBuffer_._isReadOnly16528 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
