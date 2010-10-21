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
		internal static global::MonoJavaBridge.MethodId _get22161;
		public abstract long get();
		internal static global::MonoJavaBridge.MethodId _get22162;
		public virtual global::java.nio.LongBuffer get(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get22162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get22162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22163;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get22163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get22163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22164;
		public abstract long get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22165;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22166;
		public abstract global::java.nio.LongBuffer put(long arg0);
		internal static global::MonoJavaBridge.MethodId _put22167;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _put22168;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22169;
		public virtual global::java.nio.LongBuffer put(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22170;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._equals22170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._equals22170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22171;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._toString22171)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._toString22171)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22172;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._hashCode22172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hashCode22172);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22173;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo22173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo22173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22174;
		public virtual int compareTo(java.nio.LongBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo22174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo22174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22175;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22176;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._hasArray22176);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hasArray22176);
		}
		internal static global::MonoJavaBridge.MethodId _array22177;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._array22177)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._array22177)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22178;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._arrayOffset22178);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._arrayOffset22178);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22179;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap22179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22180;
		public static global::java.nio.LongBuffer wrap(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap22180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22181;
		public static global::java.nio.LongBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._allocate22181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22182;
		public abstract global::java.nio.LongBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22183;
		public abstract global::java.nio.LongBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22184;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22185;
		public abstract global::java.nio.LongBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22186;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer._get22161 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "()J");
			global::java.nio.LongBuffer._get22162 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get22163 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get22164 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer._put22165 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22166 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22167 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22168 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22169 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._equals22170 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.LongBuffer._toString22171 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.LongBuffer._hashCode22172 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hashCode", "()I");
			global::java.nio.LongBuffer._compareTo22173 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.LongBuffer._compareTo22174 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I");
			global::java.nio.LongBuffer._isDirect22175 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer._hasArray22176 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.LongBuffer._array22177 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.LongBuffer._arrayOffset22178 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.LongBuffer._wrap22179 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._wrap22180 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._allocate22181 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._duplicate22182 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._slice22183 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._asReadOnlyBuffer22184 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._compact22185 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._order22186 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get22187;
		public override long get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get22187);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get22187);
		}
		internal static global::MonoJavaBridge.MethodId _get22188;
		public override long get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get22188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get22188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22189;
		public override global::java.nio.LongBuffer put(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put22189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put22189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22190;
		public override global::java.nio.LongBuffer put(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put22190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put22190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22191;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isDirect22191);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isDirect22191);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22192;
		public override global::java.nio.LongBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._duplicate22192)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._duplicate22192)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22193;
		public override global::java.nio.LongBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._slice22193)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._slice22193)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22194;
		public override global::java.nio.LongBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._asReadOnlyBuffer22194)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._asReadOnlyBuffer22194)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22195;
		public override global::java.nio.LongBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._compact22195)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._compact22195)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22196;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._order22196)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._order22196)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22197;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isReadOnly22197);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isReadOnly22197);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer_._get22187 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "()J");
			global::java.nio.LongBuffer_._get22188 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer_._put22189 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._put22190 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._isDirect22191 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer_._duplicate22192 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._slice22193 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._asReadOnlyBuffer22194 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._compact22195 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._order22196 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.LongBuffer_._isReadOnly22197 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
