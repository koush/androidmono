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
		internal static global::MonoJavaBridge.MethodId _get14151;
		public abstract double get();
		internal static global::MonoJavaBridge.MethodId _get14152;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get14152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get14152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14153;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get14153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get14153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14154;
		public abstract double get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put14155;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put14155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put14155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14156;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		internal static global::MonoJavaBridge.MethodId _put14157;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _put14158;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put14158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put14158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14159;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put14159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put14159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals14160;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._equals14160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._equals14160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14161;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._toString14161)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._toString14161)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14162;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hashCode14162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hashCode14162);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14163;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo14163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo14163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14164;
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo14164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo14164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect14165;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray14166;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hasArray14166);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hasArray14166);
		}
		internal static global::MonoJavaBridge.MethodId _array14167;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._array14167)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._array14167)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset14168;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._arrayOffset14168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._arrayOffset14168);
		}
		internal static global::MonoJavaBridge.MethodId _wrap14169;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap14169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap14170;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap14170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate14171;
		public static global::java.nio.DoubleBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._allocate14171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14172;
		public abstract global::java.nio.DoubleBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice14173;
		public abstract global::java.nio.DoubleBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14174;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact14175;
		public abstract global::java.nio.DoubleBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order14176;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer._get14151 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer._get14152 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get14153 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get14154 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer._put14155 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put14156 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put14157 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put14158 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put14159 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._equals14160 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.DoubleBuffer._toString14161 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.DoubleBuffer._hashCode14162 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I");
			global::java.nio.DoubleBuffer._compareTo14163 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.DoubleBuffer._compareTo14164 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I");
			global::java.nio.DoubleBuffer._isDirect14165 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer._hasArray14166 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.DoubleBuffer._array14167 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.DoubleBuffer._arrayOffset14168 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.DoubleBuffer._wrap14169 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._wrap14170 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._allocate14171 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._duplicate14172 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._slice14173 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._asReadOnlyBuffer14174 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._compact14175 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._order14176 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get14177;
		public override double get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get14177);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get14177);
		}
		internal static global::MonoJavaBridge.MethodId _get14178;
		public override double get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get14178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get14178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put14179;
		public override global::java.nio.DoubleBuffer put(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put14179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put14179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14180;
		public override global::java.nio.DoubleBuffer put(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put14180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put14180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect14181;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isDirect14181);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isDirect14181);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14182;
		public override global::java.nio.DoubleBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._duplicate14182)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._duplicate14182)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice14183;
		public override global::java.nio.DoubleBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._slice14183)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._slice14183)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14184;
		public override global::java.nio.DoubleBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._asReadOnlyBuffer14184)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._asReadOnlyBuffer14184)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact14185;
		public override global::java.nio.DoubleBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._compact14185)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._compact14185)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order14186;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._order14186)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._order14186)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly14187;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isReadOnly14187);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isReadOnly14187);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer_._get14177 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer_._get14178 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer_._put14179 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._put14180 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._isDirect14181 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer_._duplicate14182 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._slice14183 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._asReadOnlyBuffer14184 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._compact14185 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._order14186 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.DoubleBuffer_._isReadOnly14187 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
