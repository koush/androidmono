namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GestureStore : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureStore() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureStore), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.GestureStore(@__env); 
			} 
		} 
		protected GestureStore(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load2468; 
		public virtual void load(java.io.InputStream arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _load2468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _load2468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load2469; 
		public virtual void load(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _load2469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _load2469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _save2470; 
		public virtual void save(java.io.OutputStream arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _save2470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _save2470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _save2471; 
		public virtual void save(java.io.OutputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _save2471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _save2471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasChanged2472; 
		public virtual bool hasChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return @__env.CallBooleanMethod(this, _hasChanged2472); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureStore.staticClass, _hasChanged2472); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientationStyle2473; 
		public virtual void setOrientationStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _setOrientationStyle2473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _setOrientationStyle2473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientationStyle2474; 
		public virtual int getOrientationStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return @__env.CallIntMethod(this, _getOrientationStyle2474); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureStore.staticClass, _getOrientationStyle2474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSequenceType2475; 
		public virtual void setSequenceType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _setSequenceType2475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _setSequenceType2475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSequenceType2476; 
		public virtual int getSequenceType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return @__env.CallIntMethod(this, _getSequenceType2476); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureStore.staticClass, _getSequenceType2476); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureEntries2477; 
		public virtual java.util.Set getGestureEntries() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _getGestureEntries2477)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStore.staticClass, _getGestureEntries2477)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recognize2478; 
		public virtual java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _recognize2478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStore.staticClass, _recognize2478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addGesture2479; 
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _addGesture2479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _addGesture2479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGesture2480; 
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _removeGesture2480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _removeGesture2480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeEntry2481; 
		public virtual void removeEntry(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				@__env.CallVoidMethod(this, _removeEntry2481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStore.staticClass, _removeEntry2481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestures2482; 
		public virtual java.util.ArrayList getGestures(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStore)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getGestures2482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStore.staticClass, _getGestures2482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureStore2483; 
		public GestureStore()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureStore.staticClass, _GestureStore2483, this); 
		} 
		public static int SEQUENCE_INVARIANT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SEQUENCE_SENSITIVE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ORIENTATION_INVARIANT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ORIENTATION_SENSITIVE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureStore.staticClass = @__class; 
			global::android.gesture.GestureStore._load2468 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V"); 
			global::android.gesture.GestureStore._load2469 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V"); 
			global::android.gesture.GestureStore._save2470 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V"); 
			global::android.gesture.GestureStore._save2471 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V"); 
			global::android.gesture.GestureStore._hasChanged2472 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z"); 
			global::android.gesture.GestureStore._setOrientationStyle2473 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V"); 
			global::android.gesture.GestureStore._getOrientationStyle2474 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I"); 
			global::android.gesture.GestureStore._setSequenceType2475 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V"); 
			global::android.gesture.GestureStore._getSequenceType2476 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I"); 
			global::android.gesture.GestureStore._getGestureEntries2477 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;"); 
			global::android.gesture.GestureStore._recognize2478 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureStore._addGesture2479 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureStore._removeGesture2480 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureStore._removeEntry2481 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V"); 
			global::android.gesture.GestureStore._getGestures2482 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.gesture.GestureStore._GestureStore2483 = @__env.GetMethodID(global::android.gesture.GestureStore.staticClass, "<init>", "()V"); 
		} 
	} 
} 
