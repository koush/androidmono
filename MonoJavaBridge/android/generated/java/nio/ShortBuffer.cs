namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ShortBuffer_))]
	public abstract partial class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ShortBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22361;
		public abstract short get();
		internal static global::MonoJavaBridge.MethodId _get22362;
		public virtual global::java.nio.ShortBuffer get(short[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._get22362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22363;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._get22363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22364;
		public abstract short get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22365;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._put22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22366;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		internal static global::MonoJavaBridge.MethodId _put22367;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _put22368;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._put22368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22369;
		public virtual global::java.nio.ShortBuffer put(short[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._put22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22370;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.ShortBuffer._equals22370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22371;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.ShortBuffer._toString22371) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22372;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "hashCode", "()I", ref global::java.nio.ShortBuffer._hashCode22372);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22373;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.ShortBuffer._compareTo22373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22374;
		public virtual int compareTo(java.nio.ShortBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I", ref global::java.nio.ShortBuffer._compareTo22374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22375;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22376;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.ShortBuffer._hasArray22376);
		}
		internal static global::MonoJavaBridge.MethodId _array22377;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.ShortBuffer._array22377) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22378;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.ShortBuffer._arrayOffset22378);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22379;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._wrap22379.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._wrap22379 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22380;
		public static global::java.nio.ShortBuffer wrap(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._wrap22380.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._wrap22380 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22381;
		public static global::java.nio.ShortBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._allocate22381.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._allocate22381 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate22381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22382;
		public abstract global::java.nio.ShortBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22383;
		public abstract global::java.nio.ShortBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22384;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22385;
		public abstract global::java.nio.ShortBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22386;
		public abstract global::java.nio.ByteOrder order();
		static ShortBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ShortBuffer))]
	internal sealed partial class ShortBuffer_ : java.nio.ShortBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ShortBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22387;
		public override short get()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ShortBuffer_.staticClass, "get", "()S", ref global::java.nio.ShortBuffer_._get22387);
		}
		internal static global::MonoJavaBridge.MethodId _get22388;
		public override short get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ShortBuffer_.staticClass, "get", "(I)S", ref global::java.nio.ShortBuffer_._get22388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22389;
		public override global::java.nio.ShortBuffer put(short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "put", "(S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._put22389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22390;
		public override global::java.nio.ShortBuffer put(int arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._put22390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22391;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.ShortBuffer_._isDirect22391);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22392;
		public override global::java.nio.ShortBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._duplicate22392) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22393;
		public override global::java.nio.ShortBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "slice", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._slice22393) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22394;
		public override global::java.nio.ShortBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._asReadOnlyBuffer22394) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22395;
		public override global::java.nio.ShortBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "compact", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._compact22395) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22396;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.ShortBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.ShortBuffer_._order22396) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22397;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.ShortBuffer_._isReadOnly22397);
		}
		static ShortBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
