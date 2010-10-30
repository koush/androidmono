namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BitSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get25876;
		public virtual global::java.util.BitSet get(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._get25876.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._get25876 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.BitSet;
		}
		internal static global::MonoJavaBridge.MethodId _get25877;
		public virtual bool get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._get25877.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._get25877 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25878;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._equals25878.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._equals25878 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals25878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25879;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._toString25879.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._toString25879 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString25879) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25880;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._hashCode25880.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._hashCode25880 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode25880);
		}
		internal static global::MonoJavaBridge.MethodId _clone25881;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._clone25881.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._clone25881 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone25881) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear25882;
		public virtual void clear(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._clear25882.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._clear25882 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear25883;
		public virtual void clear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._clear25883.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._clear25883 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25884;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._clear25884.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._clear25884 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25884);
		}
		internal static global::MonoJavaBridge.MethodId _length25885;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._length25885.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._length25885 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "length", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._length25885);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25886;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._isEmpty25886.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._isEmpty25886 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty25886);
		}
		internal static global::MonoJavaBridge.MethodId _size25887;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._size25887.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._size25887 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._size25887);
		}
		internal static global::MonoJavaBridge.MethodId _set25888;
		public virtual void set(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._set25888.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._set25888 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25889;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._set25889.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._set25889 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25890;
		public virtual void set(int arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._set25890.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._set25890 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set25891;
		public virtual void set(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._set25891.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._set25891 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25892;
		public virtual void flip(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._flip25892.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._flip25892 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25893;
		public virtual void flip(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._flip25893.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._flip25893 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextSetBit25894;
		public virtual int nextSetBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._nextSetBit25894.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._nextSetBit25894 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit25894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextClearBit25895;
		public virtual int nextClearBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._nextClearBit25895.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._nextClearBit25895 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit25895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects25896;
		public virtual bool intersects(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._intersects25896.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._intersects25896 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects25896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cardinality25897;
		public virtual int cardinality()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._cardinality25897.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._cardinality25897 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "cardinality", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality25897);
		}
		internal static global::MonoJavaBridge.MethodId _and25898;
		public virtual void and(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._and25898.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._and25898 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._and25898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _or25899;
		public virtual void or(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._or25899.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._or25899 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._or25899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _xor25900;
		public virtual void xor(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._xor25900.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._xor25900 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor25900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _andNot25901;
		public virtual void andNot(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._andNot25901.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._andNot25901 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot25901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25902;
		public BitSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._BitSet25902.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._BitSet25902 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25902);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25903;
		public BitSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._BitSet25903.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._BitSet25903 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BitSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
