namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BitSet() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.BitSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.BitSet(@__env); 
			} 
		} 
		protected BitSet(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11823; 
		public virtual java.util.BitSet get(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallObjectMethodPtr(this, _get11823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _get11823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11824; 
		public virtual bool get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _get11824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _get11824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11825; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _hashCode11825); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _hashCode11825); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11826; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11826)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _clone11826)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11827; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _equals11827, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _equals11827, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11828; 
		public virtual void clear(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear11828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear11828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11829; 
		public virtual void clear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear11829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear11829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11830; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear11830); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear11830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11831; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11831)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _toString11831)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length11832; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _length11832); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _length11832); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11833; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _isEmpty11833); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _isEmpty11833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11834; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _size11834); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _size11834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11835; 
		public virtual void set(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set11835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set11835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11836; 
		public virtual void set(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11837; 
		public virtual void set(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set11837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set11837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11838; 
		public virtual void set(int arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set11838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set11838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flip11839; 
		public virtual void flip(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _flip11839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _flip11839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flip11840; 
		public virtual void flip(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _flip11840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _flip11840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSetBit11841; 
		public virtual int nextSetBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _nextSetBit11841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _nextSetBit11841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextClearBit11842; 
		public virtual int nextClearBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _nextClearBit11842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _nextClearBit11842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects11843; 
		public virtual bool intersects(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _intersects11843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _intersects11843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cardinality11844; 
		public virtual int cardinality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _cardinality11844); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _cardinality11844); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _and11845; 
		public virtual void and(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _and11845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _and11845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _or11846; 
		public virtual void or(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _or11846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _or11846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _xor11847; 
		public virtual void xor(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _xor11847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _xor11847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _andNot11848; 
		public virtual void andNot(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _andNot11848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _andNot11848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitSet11849; 
		public BitSet()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.BitSet.staticClass, _BitSet11849, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitSet11850; 
		public BitSet(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.BitSet.staticClass, _BitSet11850, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.BitSet.staticClass = @__class; 
			global::java.util.BitSet._get11823 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;"); 
			global::java.util.BitSet._get11824 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(I)Z"); 
			global::java.util.BitSet._hashCode11825 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "hashCode", "()I"); 
			global::java.util.BitSet._clone11826 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.BitSet._equals11827 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.BitSet._clear11828 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(II)V"); 
			global::java.util.BitSet._clear11829 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(I)V"); 
			global::java.util.BitSet._clear11830 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "()V"); 
			global::java.util.BitSet._toString11831 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.BitSet._length11832 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "length", "()I"); 
			global::java.util.BitSet._isEmpty11833 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "isEmpty", "()Z"); 
			global::java.util.BitSet._size11834 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "size", "()I"); 
			global::java.util.BitSet._set11835 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IZ)V"); 
			global::java.util.BitSet._set11836 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(I)V"); 
			global::java.util.BitSet._set11837 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(II)V"); 
			global::java.util.BitSet._set11838 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IIZ)V"); 
			global::java.util.BitSet._flip11839 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(II)V"); 
			global::java.util.BitSet._flip11840 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(I)V"); 
			global::java.util.BitSet._nextSetBit11841 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I"); 
			global::java.util.BitSet._nextClearBit11842 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I"); 
			global::java.util.BitSet._intersects11843 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z"); 
			global::java.util.BitSet._cardinality11844 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "cardinality", "()I"); 
			global::java.util.BitSet._and11845 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._or11846 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._xor11847 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._andNot11848 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._BitSet11849 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "()V"); 
			global::java.util.BitSet._BitSet11850 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
