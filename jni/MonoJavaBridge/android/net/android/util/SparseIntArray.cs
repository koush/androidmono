namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SparseIntArray : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SparseIntArray() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.SparseIntArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.SparseIntArray(@__env); 
			} 
		} 
		protected SparseIntArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7626; 
		public virtual int get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._get7626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get7626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7627; 
		public virtual int get(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._get7627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get7627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7628; 
		public virtual void put(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._put7628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put7628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7629; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._clear7629); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear7629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7630; 
		public virtual void append(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._append7630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append7630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7631; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._size7631); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size7631); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7632; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._delete7632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete7632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7633; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._keyAt7633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt7633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7634; 
		public virtual int valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._valueAt7634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt7634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7635; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._indexOfKey7635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey7635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7636; 
		public virtual int indexOfValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._indexOfValue7636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue7636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAt7637; 
		public virtual void removeAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._removeAt7637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt7637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray7638; 
		public SparseIntArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray7638, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray7639; 
		public SparseIntArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray7639, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseIntArray.staticClass = @__class; 
			global::android.util.SparseIntArray._get7626 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(I)I"); 
			global::android.util.SparseIntArray._get7627 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(II)I"); 
			global::android.util.SparseIntArray._put7628 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "put", "(II)V"); 
			global::android.util.SparseIntArray._clear7629 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "clear", "()V"); 
			global::android.util.SparseIntArray._append7630 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "append", "(II)V"); 
			global::android.util.SparseIntArray._size7631 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "size", "()I"); 
			global::android.util.SparseIntArray._delete7632 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseIntArray._keyAt7633 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseIntArray._valueAt7634 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I"); 
			global::android.util.SparseIntArray._indexOfKey7635 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseIntArray._indexOfValue7636 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I"); 
			global::android.util.SparseIntArray._removeAt7637 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V"); 
			global::android.util.SparseIntArray._SparseIntArray7638 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseIntArray._SparseIntArray7639 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
