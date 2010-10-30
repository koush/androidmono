namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.gesture.GestureLibrary_))]
	public abstract partial class GestureLibrary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureLibrary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract bool load();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract bool save();
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureLibrary.staticClass, "isReadOnly", "()Z", ref global::android.gesture.GestureLibrary._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setOrientationStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, "setOrientationStyle", "(I)V", ref global::android.gesture.GestureLibrary._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getOrientationStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureLibrary.staticClass, "getOrientationStyle", "()I", ref global::android.gesture.GestureLibrary._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSequenceType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, "setSequenceType", "(I)V", ref global::android.gesture.GestureLibrary._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getSequenceType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureLibrary.staticClass, "getSequenceType", "()I", ref global::android.gesture.GestureLibrary._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Set getGestureEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.gesture.GestureLibrary.staticClass, "getGestureEntries", "()Ljava/util/Set;", ref global::android.gesture.GestureLibrary._m7) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureLibrary.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", ref global::android.gesture.GestureLibrary._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureLibrary._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureLibrary._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void removeEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureLibrary.staticClass, "removeEntry", "(Ljava/lang/String;)V", ref global::android.gesture.GestureLibrary._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureLibrary.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.gesture.GestureLibrary._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected GestureLibrary() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibrary._m13.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibrary._m13 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureLibrary.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureLibrary.staticClass, global::android.gesture.GestureLibrary._m13);
			Init(@__env, handle);
		}
		static GestureLibrary()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureLibrary))]
	internal sealed partial class GestureLibrary_ : android.gesture.GestureLibrary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GestureLibrary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool load()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureLibrary_.staticClass, "load", "()Z", ref global::android.gesture.GestureLibrary_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool save()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureLibrary_.staticClass, "save", "()Z", ref global::android.gesture.GestureLibrary_._m1);
		}
		static GestureLibrary_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibrary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibrary"));
		}
		internal static void InitJNI()
		{
		}
	}
}
