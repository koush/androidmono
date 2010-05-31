namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ArrayList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.ArrayList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _add12708; 
		public override void add(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.ArrayList._add12708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add12708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add12709; 
		public override bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._add12709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add12709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12710; 
		public override global::java.lang.Object get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._get12710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._get12710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12711; 
		public virtual new global::java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._clone12711)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clone12711)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf12712; 
		public override int indexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.ArrayList._indexOf12712, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._indexOf12712, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12713; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.ArrayList._clear12713); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clear12713); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12714; 
		public override bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._isEmpty12714); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._isEmpty12714); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf12715; 
		public override int lastIndexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.ArrayList._lastIndexOf12715, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._lastIndexOf12715, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains12716; 
		public override bool contains(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._contains12716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._contains12716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll12717; 
		public override bool addAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._addAll12717, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll12717, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll12718; 
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._addAll12718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll12718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12719; 
		public override int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.ArrayList._size12719); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._size12719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray12720; 
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._toArray12720, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray12720, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray12721; 
		public override global::java.lang.Object[] toArray() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._toArray12721)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray12721)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12722; 
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._set12722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._set12722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12723; 
		public override global::java.lang.Object remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._remove12723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove12723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12724; 
		public override bool remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._remove12724, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove12724, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _trimToSize12725; 
		public virtual void trimToSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.ArrayList._trimToSize12725); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._trimToSize12725); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ensureCapacity12726; 
		public virtual void ensureCapacity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.ArrayList._ensureCapacity12726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._ensureCapacity12726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeRange12727; 
		protected override void removeRange(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.ArrayList._removeRange12727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._removeRange12727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList12728; 
		public ArrayList(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList12728, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList12729; 
		public ArrayList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList12729, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList12730; 
		public ArrayList(java.util.Collection arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList12730, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.ArrayList.staticClass = @__class; 
			global::java.util.ArrayList._add12708 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V"); 
			global::java.util.ArrayList._add12709 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._get12710 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::java.util.ArrayList._clone12711 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.ArrayList._indexOf12712 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.ArrayList._clear12713 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clear", "()V"); 
			global::java.util.ArrayList._isEmpty12714 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "isEmpty", "()Z"); 
			global::java.util.ArrayList._lastIndexOf12715 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.ArrayList._contains12716 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._addAll12717 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.ArrayList._addAll12718 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z"); 
			global::java.util.ArrayList._size12719 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "size", "()I"); 
			global::java.util.ArrayList._toArray12720 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"); 
			global::java.util.ArrayList._toArray12721 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;"); 
			global::java.util.ArrayList._set12722 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.ArrayList._remove12723 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;"); 
			global::java.util.ArrayList._remove12724 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z"); 
			global::java.util.ArrayList._trimToSize12725 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "trimToSize", "()V"); 
			global::java.util.ArrayList._ensureCapacity12726 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V"); 
			global::java.util.ArrayList._removeRange12727 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "removeRange", "(II)V"); 
			global::java.util.ArrayList._ArrayList12728 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(I)V"); 
			global::java.util.ArrayList._ArrayList12729 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "()V"); 
			global::java.util.ArrayList._ArrayList12730 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V"); 
		} 
	} 
} 
