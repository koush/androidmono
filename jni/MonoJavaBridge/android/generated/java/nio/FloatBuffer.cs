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
		internal static global::MonoJavaBridge.MethodId _get22205;
		public abstract float get();
		internal static global::MonoJavaBridge.MethodId _get22206;
		public virtual global::java.nio.FloatBuffer get(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get22206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get22206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22207;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._get22207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get22207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22208;
		public abstract float get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22209;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22210;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		internal static global::MonoJavaBridge.MethodId _put22211;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _put22212;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22213;
		public virtual global::java.nio.FloatBuffer put(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._put22213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put22213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22214;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._equals22214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals22214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22215;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._toString22215)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString22215)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22216;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._hashCode22216);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode22216);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22217;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo22217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo22217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22218;
		public virtual int compareTo(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._compareTo22218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo22218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22219;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22220;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer._hasArray22220);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hasArray22220);
		}
		internal static global::MonoJavaBridge.MethodId _array22221;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer._array22221)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._array22221)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22222;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.FloatBuffer._arrayOffset22222);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._arrayOffset22222);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22223;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap22223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22224;
		public static global::java.nio.FloatBuffer wrap(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap22224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22225;
		public static global::java.nio.FloatBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate22225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22226;
		public abstract global::java.nio.FloatBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22227;
		public abstract global::java.nio.FloatBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22228;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22229;
		public abstract global::java.nio.FloatBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22230;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer._get22205 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "()F");
			global::java.nio.FloatBuffer._get22206 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get22207 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._get22208 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer._put22209 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22210 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22211 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22212 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._put22213 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._equals22214 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.FloatBuffer._toString22215 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.FloatBuffer._hashCode22216 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I");
			global::java.nio.FloatBuffer._compareTo22217 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.FloatBuffer._compareTo22218 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I");
			global::java.nio.FloatBuffer._isDirect22219 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer._hasArray22220 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.FloatBuffer._array22221 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.FloatBuffer._arrayOffset22222 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.FloatBuffer._wrap22223 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._wrap22224 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._allocate22225 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._duplicate22226 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._slice22227 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._asReadOnlyBuffer22228 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._compact22229 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer._order22230 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.FloatBuffer))]
	internal sealed partial class FloatBuffer_ : java.nio.FloatBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FloatBuffer_()
		{
			InitJNI();
		}
		internal FloatBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22231;
		public override float get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get22231);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get22231);
		}
		internal static global::MonoJavaBridge.MethodId _get22232;
		public override float get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_._get22232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._get22232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22233;
		public override global::java.nio.FloatBuffer put(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put22233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put22233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22234;
		public override global::java.nio.FloatBuffer put(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._put22234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._put22234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22235;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isDirect22235);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isDirect22235);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22236;
		public override global::java.nio.FloatBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._duplicate22236)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._duplicate22236)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22237;
		public override global::java.nio.FloatBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._slice22237)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._slice22237)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22238;
		public override global::java.nio.FloatBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._asReadOnlyBuffer22238)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._asReadOnlyBuffer22238)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22239;
		public override global::java.nio.FloatBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._compact22239)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._compact22239)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22240;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_._order22240)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._order22240)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22241;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_._isReadOnly22241);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.FloatBuffer_.staticClass, global::java.nio.FloatBuffer_._isReadOnly22241);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
			global::java.nio.FloatBuffer_._get22231 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "()F");
			global::java.nio.FloatBuffer_._get22232 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "get", "(I)F");
			global::java.nio.FloatBuffer_._put22233 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(F)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._put22234 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._isDirect22235 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.FloatBuffer_._duplicate22236 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._slice22237 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "slice", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._asReadOnlyBuffer22238 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._compact22239 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "compact", "()Ljava/nio/FloatBuffer;");
			global::java.nio.FloatBuffer_._order22240 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.FloatBuffer_._isReadOnly22241 = @__env.GetMethodIDNoThrow(global::java.nio.FloatBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
