namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.LongBuffer_))]
	public abstract partial class LongBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LongBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22280;
		public abstract long get();
		internal static global::MonoJavaBridge.MethodId _get22281;
		public virtual global::java.nio.LongBuffer get(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get22281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get22281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22282;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._get22282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._get22282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22283;
		public abstract long get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22284;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22285;
		public abstract global::java.nio.LongBuffer put(long arg0);
		internal static global::MonoJavaBridge.MethodId _put22286;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _put22287;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22288;
		public virtual global::java.nio.LongBuffer put(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._put22288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._put22288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22289;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._equals22289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._equals22289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22290;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._toString22290)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._toString22290)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22291;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._hashCode22291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hashCode22291);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22292;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo22292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo22292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22293;
		public virtual int compareTo(java.nio.LongBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._compareTo22293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._compareTo22293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22294;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22295;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer._hasArray22295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._hasArray22295);
		}
		internal static global::MonoJavaBridge.MethodId _array22296;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer._array22296)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._array22296)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22297;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.LongBuffer._arrayOffset22297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._arrayOffset22297);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22298;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap22298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22299;
		public static global::java.nio.LongBuffer wrap(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._wrap22299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22300;
		public static global::java.nio.LongBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._allocate22300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22301;
		public abstract global::java.nio.LongBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22302;
		public abstract global::java.nio.LongBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22303;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22304;
		public abstract global::java.nio.LongBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22305;
		public abstract global::java.nio.ByteOrder order();
		static LongBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer._get22280 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "()J");
			global::java.nio.LongBuffer._get22281 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get22282 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._get22283 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer._put22284 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22285 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22286 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22287 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._put22288 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._equals22289 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.LongBuffer._toString22290 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.LongBuffer._hashCode22291 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hashCode", "()I");
			global::java.nio.LongBuffer._compareTo22292 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.LongBuffer._compareTo22293 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I");
			global::java.nio.LongBuffer._isDirect22294 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer._hasArray22295 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.LongBuffer._array22296 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.LongBuffer._arrayOffset22297 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.LongBuffer._wrap22298 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._wrap22299 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._allocate22300 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._duplicate22301 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._slice22302 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._asReadOnlyBuffer22303 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._compact22304 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer._order22305 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.LongBuffer))]
	internal sealed partial class LongBuffer_ : java.nio.LongBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LongBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22306;
		public override long get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get22306);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get22306);
		}
		internal static global::MonoJavaBridge.MethodId _get22307;
		public override long get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.LongBuffer_._get22307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._get22307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22308;
		public override global::java.nio.LongBuffer put(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put22308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put22308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22309;
		public override global::java.nio.LongBuffer put(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._put22309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._put22309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22310;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isDirect22310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isDirect22310);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22311;
		public override global::java.nio.LongBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._duplicate22311)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._duplicate22311)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22312;
		public override global::java.nio.LongBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._slice22312)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._slice22312)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22313;
		public override global::java.nio.LongBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._asReadOnlyBuffer22313)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._asReadOnlyBuffer22313)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22314;
		public override global::java.nio.LongBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._compact22314)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._compact22314)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22315;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_._order22315)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._order22315)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22316;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_._isReadOnly22316);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.LongBuffer_.staticClass, global::java.nio.LongBuffer_._isReadOnly22316);
		}
		static LongBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
			global::java.nio.LongBuffer_._get22306 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "()J");
			global::java.nio.LongBuffer_._get22307 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "get", "(I)J");
			global::java.nio.LongBuffer_._put22308 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(J)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._put22309 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._isDirect22310 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.LongBuffer_._duplicate22311 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "duplicate", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._slice22312 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "slice", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._asReadOnlyBuffer22313 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._compact22314 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "compact", "()Ljava/nio/LongBuffer;");
			global::java.nio.LongBuffer_._order22315 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.LongBuffer_._isReadOnly22316 = @__env.GetMethodIDNoThrow(global::java.nio.LongBuffer_.staticClass, "isReadOnly", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
