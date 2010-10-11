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
		internal static global::MonoJavaBridge.MethodId _get14188;
		public abstract float get();
		internal static global::MonoJavaBridge.MethodId _get14189;
		public virtual global::java.nio.FloatBuffer get(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get14189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get14189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14190;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get14190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get14190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get14191;
		public abstract float get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put14192;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put14192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put14192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14193;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		internal static global::MonoJavaBridge.MethodId _put14194;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _put14195;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put14195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put14195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14196;
		public virtual global::java.nio.FloatBuffer put(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put14196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put14196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals14197;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._equals14197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals14197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14198;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._toString14198)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString14198)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14199;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._hashCode14199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode14199);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14200;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo14200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo14200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14201;
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo14201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo14201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect14202;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray14203;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._hasArray14203);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hasArray14203);
		}
		internal static global::MonoJavaBridge.MethodId _array14204;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._array14204)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._array14204)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset14205;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._arrayOffset14205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._arrayOffset14205);
		}
		internal static global::MonoJavaBridge.MethodId _wrap14206;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap14206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap14207;
		public static global::java.nio.FloatBuffer wrap(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap14207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate14208;
		public static global::java.nio.FloatBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate14208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14209;
		public abstract global::java.nio.FloatBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice14210;
		public abstract global::java.nio.FloatBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14211;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact14212;
		public abstract global::java.nio.FloatBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order14213;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer._get14188 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "()F");
			global::java.nio.FloatBuffer._get14189 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get14190 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get14191 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer._put14192 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put14193 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put14194 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put14195 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put14196 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._equals14197 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.FloatBuffer._toString14198 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.FloatBuffer._hashCode14199 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I");
			global::java.nio.FloatBuffer._compareTo14200 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.FloatBuffer._compareTo14201 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I");
			global::java.nio.FloatBuffer._isDirect14202 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer._hasArray14203 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.FloatBuffer._array14204 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.FloatBuffer._arrayOffset14205 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.FloatBuffer._wrap14206 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._wrap14207 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._allocate14208 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._duplicate14209 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._slice14210 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._asReadOnlyBuffer14211 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._compact14212 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._order14213 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
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
		internal static global::MonoJavaBridge.MethodId _get14214;
		public override float get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get14214);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get14214);
		}
		internal static global::MonoJavaBridge.MethodId _get14215;
		public override float get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get14215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get14215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put14216;
		public override global::java.nio.FloatBuffer put(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put14216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put14216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put14217;
		public override global::java.nio.FloatBuffer put(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put14217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put14217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect14218;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isDirect14218);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isDirect14218);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate14219;
		public override global::java.nio.FloatBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._duplicate14219)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._duplicate14219)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice14220;
		public override global::java.nio.FloatBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._slice14220)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._slice14220)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer14221;
		public override global::java.nio.FloatBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._asReadOnlyBuffer14221)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._asReadOnlyBuffer14221)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact14222;
		public override global::java.nio.FloatBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._compact14222)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._compact14222)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order14223;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._order14223)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._order14223)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly14224;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isReadOnly14224);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isReadOnly14224);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer_._get14214 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "()F");
			global::java.nio.FloatBuffer_._get14215 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer_._put14216 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._put14217 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._isDirect14218 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer_._duplicate14219 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._slice14220 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._asReadOnlyBuffer14221 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._compact14222 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._order14223 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.FloatBuffer_._isReadOnly14224 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
