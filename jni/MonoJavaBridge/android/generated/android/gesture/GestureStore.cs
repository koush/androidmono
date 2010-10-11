namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureStore()
		{
			InitJNI();
		}
		protected GestureStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load3033;
		public virtual void load(java.io.InputStream arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._load3033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load3033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load3034;
		public virtual void load(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._load3034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load3034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save3035;
		public virtual void save(java.io.OutputStream arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._save3035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save3035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _save3036;
		public virtual void save(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._save3036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save3036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged3037;
		public virtual bool hasChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureStore._hasChanged3037);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._hasChanged3037);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle3038;
		public virtual void setOrientationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._setOrientationStyle3038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setOrientationStyle3038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle3039;
		public virtual int getOrientationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureStore._getOrientationStyle3039);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getOrientationStyle3039);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType3040;
		public virtual void setSequenceType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._setSequenceType3040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setSequenceType3040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceType3041;
		public virtual int getSequenceType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureStore._getSequenceType3041);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getSequenceType3041);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries3042;
		public virtual global::java.util.Set getGestureEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._getGestureEntries3042)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestureEntries3042)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize3043;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._recognize3043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._recognize3043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture3044;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._addGesture3044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._addGesture3044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture3045;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._removeGesture3045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeGesture3045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry3046;
		public virtual void removeEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._removeEntry3046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeEntry3046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures3047;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._getGestures3047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestures3047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureStore3048;
		public GestureStore()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._GestureStore3048);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStore"));
			global::android.gesture.GestureStore._load3033 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V");
			global::android.gesture.GestureStore._load3034 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::android.gesture.GestureStore._save3035 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V");
			global::android.gesture.GestureStore._save3036 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V");
			global::android.gesture.GestureStore._hasChanged3037 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z");
			global::android.gesture.GestureStore._setOrientationStyle3038 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V");
			global::android.gesture.GestureStore._getOrientationStyle3039 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I");
			global::android.gesture.GestureStore._setSequenceType3040 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V");
			global::android.gesture.GestureStore._getSequenceType3041 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I");
			global::android.gesture.GestureStore._getGestureEntries3042 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			global::android.gesture.GestureStore._recognize3043 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._addGesture3044 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeGesture3045 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeEntry3046 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::android.gesture.GestureStore._getGestures3047 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._GestureStore3048 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "<init>", "()V");
		}
	}
}
