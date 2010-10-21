namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BitSet()
		{
			InitJNI();
		}
		protected BitSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get25757;
		public virtual global::java.util.BitSet get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._get25757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
		}
		internal static global::MonoJavaBridge.MethodId _get25758;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._get25758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25759;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._equals25759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals25759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25760;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._toString25760)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString25760)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25761;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._hashCode25761);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode25761);
		}
		internal static global::MonoJavaBridge.MethodId _clone25762;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._clone25762)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone25762)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear25763;
		public virtual void clear(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear25764;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25765;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25765);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25765);
		}
		internal static global::MonoJavaBridge.MethodId _length25766;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._length25766);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._length25766);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25767;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._isEmpty25767);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty25767);
		}
		internal static global::MonoJavaBridge.MethodId _size25768;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._size25768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._size25768);
		}
		internal static global::MonoJavaBridge.MethodId _set25769;
		public virtual void set(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25770;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25771;
		public virtual void set(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set25772;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25773;
		public virtual void flip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip25773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25774;
		public virtual void flip(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip25774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextSetBit25775;
		public virtual int nextSetBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextSetBit25775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit25775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextClearBit25776;
		public virtual int nextClearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextClearBit25776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit25776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects25777;
		public virtual bool intersects(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._intersects25777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects25777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cardinality25778;
		public virtual int cardinality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._cardinality25778);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality25778);
		}
		internal static global::MonoJavaBridge.MethodId _and25779;
		public virtual void and(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._and25779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._and25779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _or25780;
		public virtual void or(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._or25780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._or25780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _xor25781;
		public virtual void xor(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._xor25781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor25781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _andNot25782;
		public virtual void andNot(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._andNot25782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot25782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25783;
		public BitSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25783);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25784;
		public BitSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
			global::java.util.BitSet._get25757 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			global::java.util.BitSet._get25758 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(I)Z");
			global::java.util.BitSet._equals25759 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.BitSet._toString25760 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.BitSet._hashCode25761 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "hashCode", "()I");
			global::java.util.BitSet._clone25762 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.BitSet._clear25763 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::java.util.BitSet._clear25764 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::java.util.BitSet._clear25765 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "()V");
			global::java.util.BitSet._length25766 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "length", "()I");
			global::java.util.BitSet._isEmpty25767 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			global::java.util.BitSet._size25768 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "size", "()I");
			global::java.util.BitSet._set25769 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::java.util.BitSet._set25770 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::java.util.BitSet._set25771 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::java.util.BitSet._set25772 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::java.util.BitSet._flip25773 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::java.util.BitSet._flip25774 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::java.util.BitSet._nextSetBit25775 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			global::java.util.BitSet._nextClearBit25776 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			global::java.util.BitSet._intersects25777 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			global::java.util.BitSet._cardinality25778 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "cardinality", "()I");
			global::java.util.BitSet._and25779 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._or25780 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._xor25781 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._andNot25782 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._BitSet25783 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::java.util.BitSet._BitSet25784 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
		}
	}
}
