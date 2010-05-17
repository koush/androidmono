namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ArrayList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.ArrayList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.ArrayList(@__env); 
			} 
		} 
		protected ArrayList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11800; 
		public override void add(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				@__env.CallVoidMethod(this, _add11800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.ArrayList.staticClass, _add11800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11801; 
		public override bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _add11801, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _add11801, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11802; 
		public override java.lang.Object get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get11802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _get11802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11803; 
		public virtual new java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11803)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _clone11803)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf11804; 
		public override int indexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallIntMethod(this, _indexOf11804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.ArrayList.staticClass, _indexOf11804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11805; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				@__env.CallVoidMethod(this, _clear11805); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.ArrayList.staticClass, _clear11805); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11806; 
		public override bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _isEmpty11806); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _isEmpty11806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf11807; 
		public override int lastIndexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallIntMethod(this, _lastIndexOf11807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.ArrayList.staticClass, _lastIndexOf11807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains11808; 
		public override bool contains(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _contains11808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _contains11808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll11809; 
		public override bool addAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _addAll11809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _addAll11809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll11810; 
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _addAll11810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _addAll11810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11811; 
		public override int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallIntMethod(this, _size11811); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.ArrayList.staticClass, _size11811); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray11812; 
		public override java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{ 
			if (GetType() == typeof(java.util.ArrayList)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toArray11812, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _toArray11812, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray11813; 
		public override java.lang.Object[] toArray() 
		{ 
			if (GetType() == typeof(java.util.ArrayList)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toArray11813)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _toArray11813)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11814; 
		public override java.lang.Object set(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _set11814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _set11814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove11815; 
		public override java.lang.Object remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove11815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.ArrayList.staticClass, _remove11815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove11816; 
		public override bool remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				return @__env.CallBooleanMethod(this, _remove11816, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.ArrayList.staticClass, _remove11816, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _trimToSize11817; 
		public virtual void trimToSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				@__env.CallVoidMethod(this, _trimToSize11817); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.ArrayList.staticClass, _trimToSize11817); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ensureCapacity11818; 
		public virtual void ensureCapacity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				@__env.CallVoidMethod(this, _ensureCapacity11818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.ArrayList.staticClass, _ensureCapacity11818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeRange11819; 
		protected override void removeRange(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.ArrayList)) 
				@__env.CallVoidMethod(this, _removeRange11819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.ArrayList.staticClass, _removeRange11819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList11820; 
		public ArrayList(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, _ArrayList11820, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList11821; 
		public ArrayList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, _ArrayList11821, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList11822; 
		public ArrayList(java.util.Collection arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, _ArrayList11822, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.ArrayList.staticClass = @__class; 
			global::java.util.ArrayList._add11800 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V"); 
			global::java.util.ArrayList._add11801 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._get11802 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::java.util.ArrayList._clone11803 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.ArrayList._indexOf11804 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.ArrayList._clear11805 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clear", "()V"); 
			global::java.util.ArrayList._isEmpty11806 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "isEmpty", "()Z"); 
			global::java.util.ArrayList._lastIndexOf11807 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.ArrayList._contains11808 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._addAll11809 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.ArrayList._addAll11810 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z"); 
			global::java.util.ArrayList._size11811 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "size", "()I"); 
			global::java.util.ArrayList._toArray11812 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"); 
			global::java.util.ArrayList._toArray11813 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;"); 
			global::java.util.ArrayList._set11814 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.ArrayList._remove11815 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;"); 
			global::java.util.ArrayList._remove11816 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._trimToSize11817 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "trimToSize", "()V"); 
			global::java.util.ArrayList._ensureCapacity11818 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V"); 
			global::java.util.ArrayList._removeRange11819 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "removeRange", "(II)V"); 
			global::java.util.ArrayList._ArrayList11820 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(I)V"); 
			global::java.util.ArrayList._ArrayList11821 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "()V"); 
			global::java.util.ArrayList._ArrayList11822 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V"); 
		} 
	} 
} 
