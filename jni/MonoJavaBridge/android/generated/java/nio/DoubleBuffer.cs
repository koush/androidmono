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
		internal static global::MonoJavaBridge.MethodId _get22168;
		public abstract double get();
		internal static global::MonoJavaBridge.MethodId _get22169;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get22169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get22169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22170;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get22170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get22170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22171;
		public abstract double get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22172;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22173;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		internal static global::MonoJavaBridge.MethodId _put22174;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _put22175;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22176;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22177;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._equals22177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._equals22177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22178;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._toString22178)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._toString22178)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22179;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hashCode22179);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hashCode22179);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22180;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo22180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo22180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22181;
		public virtual int compareTo(java.nio.DoubleBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo22181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo22181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22182;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22183;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hasArray22183);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hasArray22183);
		}
		internal static global::MonoJavaBridge.MethodId _array22184;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._array22184)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._array22184)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22185;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._arrayOffset22185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._arrayOffset22185);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22186;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap22186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22187;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap22187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22188;
		public static global::java.nio.DoubleBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._allocate22188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22189;
		public abstract global::java.nio.DoubleBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22190;
		public abstract global::java.nio.DoubleBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22191;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22192;
		public abstract global::java.nio.DoubleBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22193;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer._get22168 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer._get22169 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get22170 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get22171 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer._put22172 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22173 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22174 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22175 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22176 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._equals22177 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.DoubleBuffer._toString22178 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.DoubleBuffer._hashCode22179 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I");
			global::java.nio.DoubleBuffer._compareTo22180 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.DoubleBuffer._compareTo22181 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I");
			global::java.nio.DoubleBuffer._isDirect22182 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer._hasArray22183 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.DoubleBuffer._array22184 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.DoubleBuffer._arrayOffset22185 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.DoubleBuffer._wrap22186 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._wrap22187 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._allocate22188 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._duplicate22189 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._slice22190 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._asReadOnlyBuffer22191 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._compact22192 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._order22193 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.DoubleBuffer))]
	internal sealed partial class DoubleBuffer_ : java.nio.DoubleBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DoubleBuffer_()
		{
			InitJNI();
		}
		internal DoubleBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22194;
		public override double get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get22194);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get22194);
		}
		internal static global::MonoJavaBridge.MethodId _get22195;
		public override double get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get22195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get22195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22196;
		public override global::java.nio.DoubleBuffer put(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put22196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put22196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22197;
		public override global::java.nio.DoubleBuffer put(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put22197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put22197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22198;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isDirect22198);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isDirect22198);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22199;
		public override global::java.nio.DoubleBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._duplicate22199)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._duplicate22199)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22200;
		public override global::java.nio.DoubleBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._slice22200)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._slice22200)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22201;
		public override global::java.nio.DoubleBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._asReadOnlyBuffer22201)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._asReadOnlyBuffer22201)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22202;
		public override global::java.nio.DoubleBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._compact22202)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._compact22202)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22203;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._order22203)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._order22203)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22204;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isReadOnly22204);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isReadOnly22204);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer_._get22194 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer_._get22195 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer_._put22196 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._put22197 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._isDirect22198 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer_._duplicate22199 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._slice22200 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._asReadOnlyBuffer22201 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._compact22202 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._order22203 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.DoubleBuffer_._isReadOnly22204 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
