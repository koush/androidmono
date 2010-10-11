namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.gesture.GestureLibrary_))]
	public abstract partial class GestureLibrary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureLibrary()
		{
			InitJNI();
		}
		protected GestureLibrary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load2957;
		public abstract bool load();
		internal static global::MonoJavaBridge.MethodId _save2958;
		public abstract bool save();
		internal static global::MonoJavaBridge.MethodId _isReadOnly2959;
		public virtual bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary._isReadOnly2959);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._isReadOnly2959);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle2960;
		public virtual void setOrientationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._setOrientationStyle2960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setOrientationStyle2960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle2961;
		public virtual int getOrientationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getOrientationStyle2961);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getOrientationStyle2961);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType2962;
		public virtual void setSequenceType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._setSequenceType2962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._setSequenceType2962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceType2963;
		public virtual int getSequenceType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getSequenceType2963);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getSequenceType2963);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries2964;
		public virtual global::java.util.Set getGestureEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getGestureEntries2964)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestureEntries2964)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize2965;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._recognize2965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._recognize2965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture2966;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._addGesture2966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._addGesture2966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture2967;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._removeGesture2967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeGesture2967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry2968;
		public virtual void removeEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary._removeEntry2968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._removeEntry2968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures2969;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary._getGestures2969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._getGestures2969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureLibrary2970;
		protected GestureLibrary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._GestureLibrary2970);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
			global::android.gesture.GestureLibrary._load2957 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "load", "()Z");
			global::android.gesture.GestureLibrary._save2958 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "save", "()Z");
			global::android.gesture.GestureLibrary._isReadOnly2959 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z");
			global::android.gesture.GestureLibrary._setOrientationStyle2960 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V");
			global::android.gesture.GestureLibrary._getOrientationStyle2961 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I");
			global::android.gesture.GestureLibrary._setSequenceType2962 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V");
			global::android.gesture.GestureLibrary._getSequenceType2963 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I");
			global::android.gesture.GestureLibrary._getGestureEntries2964 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			global::android.gesture.GestureLibrary._recognize2965 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			global::android.gesture.GestureLibrary._addGesture2966 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureLibrary._removeGesture2967 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureLibrary._removeEntry2968 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::android.gesture.GestureLibrary._getGestures2969 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.gesture.GestureLibrary._GestureLibrary2970 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureLibrary))]
	public sealed partial class GestureLibrary_ : android.gesture.GestureLibrary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureLibrary_()
		{
			InitJNI();
		}
		internal GestureLibrary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load2971;
		public override bool load() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._load2971);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_.staticClass, global::android.gesture.GestureLibrary_._load2971);
		}
		internal static global::MonoJavaBridge.MethodId _save2972;
		public override bool save() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_._save2972);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureLibrary_.staticClass, global::android.gesture.GestureLibrary_._save2972);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
			global::android.gesture.GestureLibrary_._load2971 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "load", "()Z");
			global::android.gesture.GestureLibrary_._save2972 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary_.staticClass, "save", "()Z");
		}
	}
}
