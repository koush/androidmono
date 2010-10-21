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
		internal static global::MonoJavaBridge.MethodId _get22049;
		public abstract double get();
		internal static global::MonoJavaBridge.MethodId _get22050;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get22050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get22050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22051;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._get22051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._get22051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22052;
		public abstract double get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22053;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22054;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		internal static global::MonoJavaBridge.MethodId _put22055;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _put22056;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22057;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._put22057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._put22057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22058;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._equals22058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._equals22058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22059;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._toString22059)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._toString22059)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22060;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hashCode22060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hashCode22060);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22061;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo22061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo22061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22062;
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._compareTo22062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._compareTo22062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22063;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22064;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer._hasArray22064);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._hasArray22064);
		}
		internal static global::MonoJavaBridge.MethodId _array22065;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer._array22065)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._array22065)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22066;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer._arrayOffset22066);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._arrayOffset22066);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22067;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap22067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22068;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._wrap22068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22069;
		public static global::java.nio.DoubleBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._allocate22069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22070;
		public abstract global::java.nio.DoubleBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22071;
		public abstract global::java.nio.DoubleBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22072;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22073;
		public abstract global::java.nio.DoubleBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22074;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer._get22049 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer._get22050 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get22051 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._get22052 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer._put22053 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22054 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22055 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22056 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._put22057 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._equals22058 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.DoubleBuffer._toString22059 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.DoubleBuffer._hashCode22060 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I");
			global::java.nio.DoubleBuffer._compareTo22061 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.DoubleBuffer._compareTo22062 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I");
			global::java.nio.DoubleBuffer._isDirect22063 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer._hasArray22064 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.DoubleBuffer._array22065 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.DoubleBuffer._arrayOffset22066 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.DoubleBuffer._wrap22067 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._wrap22068 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._allocate22069 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._duplicate22070 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._slice22071 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._asReadOnlyBuffer22072 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._compact22073 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer._order22074 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get22075;
		public override double get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get22075);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get22075);
		}
		internal static global::MonoJavaBridge.MethodId _get22076;
		public override double get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._get22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._get22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22077;
		public override global::java.nio.DoubleBuffer put(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22078;
		public override global::java.nio.DoubleBuffer put(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._put22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._put22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22079;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isDirect22079);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isDirect22079);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22080;
		public override global::java.nio.DoubleBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._duplicate22080)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._duplicate22080)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22081;
		public override global::java.nio.DoubleBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._slice22081)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._slice22081)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22082;
		public override global::java.nio.DoubleBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._asReadOnlyBuffer22082)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._asReadOnlyBuffer22082)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22083;
		public override global::java.nio.DoubleBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._compact22083)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._compact22083)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22084;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._order22084)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._order22084)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22085;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_._isReadOnly22085);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.DoubleBuffer_.staticClass, global::java.nio.DoubleBuffer_._isReadOnly22085);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
			global::java.nio.DoubleBuffer_._get22075 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "()D");
			global::java.nio.DoubleBuffer_._get22076 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "get", "(I)D");
			global::java.nio.DoubleBuffer_._put22077 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._put22078 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._isDirect22079 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.DoubleBuffer_._duplicate22080 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._slice22081 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "slice", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._asReadOnlyBuffer22082 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._compact22083 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "compact", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.DoubleBuffer_._order22084 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.DoubleBuffer_._isReadOnly22085 = @__env.GetMethodIDNoThrow(global::java.nio.DoubleBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
