namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.IntBuffer_))]
	public abstract partial class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22242;
		public abstract int get();
		internal static global::MonoJavaBridge.MethodId _get22243;
		public virtual global::java.nio.IntBuffer get(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22244;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22245;
		public abstract int get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22246;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22247;
		public abstract global::java.nio.IntBuffer put(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22248;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _put22249;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22250;
		public virtual global::java.nio.IntBuffer put(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22251;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals22251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22252;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString22252)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22253;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode22253);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22254;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22255;
		public virtual int compareTo(java.nio.IntBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22256;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22257;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hasArray22257);
		}
		internal static global::MonoJavaBridge.MethodId _array22258;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._array22258)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22259;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._arrayOffset22259);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22260;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22261;
		public static global::java.nio.IntBuffer wrap(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22262;
		public static global::java.nio.IntBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate22262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22263;
		public abstract global::java.nio.IntBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22264;
		public abstract global::java.nio.IntBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22265;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22266;
		public abstract global::java.nio.IntBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22267;
		public abstract global::java.nio.ByteOrder order();
		static IntBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer._get22242 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "()I");
			global::java.nio.IntBuffer._get22243 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22244 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22245 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer._put22246 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22247 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22248 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22249 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22250 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._equals22251 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.IntBuffer._toString22252 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.IntBuffer._hashCode22253 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hashCode", "()I");
			global::java.nio.IntBuffer._compareTo22254 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.IntBuffer._compareTo22255 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I");
			global::java.nio.IntBuffer._isDirect22256 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer._hasArray22257 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.IntBuffer._array22258 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.IntBuffer._arrayOffset22259 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.IntBuffer._wrap22260 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._wrap22261 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._allocate22262 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._duplicate22263 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._slice22264 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._asReadOnlyBuffer22265 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._compact22266 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._order22267 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.IntBuffer))]
	internal sealed partial class IntBuffer_ : java.nio.IntBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IntBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22268;
		public override int get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22268);
		}
		internal static global::MonoJavaBridge.MethodId _get22269;
		public override int get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22270;
		public override global::java.nio.IntBuffer put(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22271;
		public override global::java.nio.IntBuffer put(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22272;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isDirect22272);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22273;
		public override global::java.nio.IntBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._duplicate22273)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22274;
		public override global::java.nio.IntBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._slice22274)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22275;
		public override global::java.nio.IntBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._asReadOnlyBuffer22275)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22276;
		public override global::java.nio.IntBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._compact22276)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22277;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._order22277)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22278;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isReadOnly22278);
		}
		static IntBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer_._get22268 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "()I");
			global::java.nio.IntBuffer_._get22269 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer_._put22270 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._put22271 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._isDirect22272 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer_._duplicate22273 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._slice22274 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._asReadOnlyBuffer22275 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._compact22276 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._order22277 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.IntBuffer_._isReadOnly22278 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isReadOnly", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
