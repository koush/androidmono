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
		internal static global::MonoJavaBridge.MethodId _get22086;
		public abstract float get();
		internal static global::MonoJavaBridge.MethodId _get22087;
		public virtual global::java.nio.FloatBuffer get(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get22087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get22087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22088;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22089;
		public abstract float get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22090;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22091;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		internal static global::MonoJavaBridge.MethodId _put22092;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _put22093;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22094;
		public virtual global::java.nio.FloatBuffer put(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22095;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._equals22095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals22095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22096;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._toString22096)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString22096)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22097;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._hashCode22097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode22097);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22098;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo22098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo22098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22099;
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo22099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo22099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22100;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22101;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._hasArray22101);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hasArray22101);
		}
		internal static global::MonoJavaBridge.MethodId _array22102;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._array22102)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._array22102)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22103;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._arrayOffset22103);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._arrayOffset22103);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22104;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap22104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22105;
		public static global::java.nio.FloatBuffer wrap(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap22105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22106;
		public static global::java.nio.FloatBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate22106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22107;
		public abstract global::java.nio.FloatBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22108;
		public abstract global::java.nio.FloatBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22109;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22110;
		public abstract global::java.nio.FloatBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22111;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer._get22086 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "()F");
			global::java.nio.FloatBuffer._get22087 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get22088 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get22089 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer._put22090 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22091 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22092 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22093 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22094 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._equals22095 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.FloatBuffer._toString22096 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.FloatBuffer._hashCode22097 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I");
			global::java.nio.FloatBuffer._compareTo22098 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.FloatBuffer._compareTo22099 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I");
			global::java.nio.FloatBuffer._isDirect22100 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer._hasArray22101 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.FloatBuffer._array22102 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.FloatBuffer._arrayOffset22103 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.FloatBuffer._wrap22104 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._wrap22105 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._allocate22106 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._duplicate22107 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._slice22108 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._asReadOnlyBuffer22109 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._compact22110 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._order22111 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get22112;
		public override float get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get22112);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get22112);
		}
		internal static global::MonoJavaBridge.MethodId _get22113;
		public override float get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get22113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get22113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22114;
		public override global::java.nio.FloatBuffer put(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put22114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put22114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22115;
		public override global::java.nio.FloatBuffer put(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put22115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put22115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22116;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isDirect22116);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isDirect22116);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22117;
		public override global::java.nio.FloatBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._duplicate22117)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._duplicate22117)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22118;
		public override global::java.nio.FloatBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._slice22118)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._slice22118)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22119;
		public override global::java.nio.FloatBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._asReadOnlyBuffer22119)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._asReadOnlyBuffer22119)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22120;
		public override global::java.nio.FloatBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._compact22120)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._compact22120)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22121;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._order22121)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._order22121)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22122;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isReadOnly22122);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isReadOnly22122);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer_._get22112 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "()F");
			global::java.nio.FloatBuffer_._get22113 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer_._put22114 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._put22115 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._isDirect22116 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer_._duplicate22117 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._slice22118 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._asReadOnlyBuffer22119 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._compact22120 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._order22121 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.FloatBuffer_._isReadOnly22122 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
