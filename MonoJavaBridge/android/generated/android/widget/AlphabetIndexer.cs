namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphabetIndexer : android.database.DataSetObserver, SectionIndexer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlphabetIndexer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual int compare(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::android.widget.AlphabetIndexer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.database.Cursor Cursor
		{
			set
			{
				setCursor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, "setCursor", "(Landroid/database/Cursor;)V", ref global::android.widget.AlphabetIndexer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void onChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, "onChanged", "()V", ref global::android.widget.AlphabetIndexer._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void onInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AlphabetIndexer.staticClass, "onInvalidated", "()V", ref global::android.widget.AlphabetIndexer._m3);
		}
		public new global::java.lang.Object[] Sections
		{
			get
			{
				return getSections();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Object[] getSections()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.widget.AlphabetIndexer.staticClass, "getSections", "()[Ljava/lang/Object;", ref global::android.widget.AlphabetIndexer._m4) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getPositionForSection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, "getPositionForSection", "(I)I", ref global::android.widget.AlphabetIndexer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getSectionForPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AlphabetIndexer.staticClass, "getSectionForPosition", "(I)I", ref global::android.widget.AlphabetIndexer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AlphabetIndexer(android.database.Cursor arg0, int arg1, java.lang.CharSequence arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AlphabetIndexer._m7.native == global::System.IntPtr.Zero)
				global::android.widget.AlphabetIndexer._m7 = @__env.GetMethodIDNoThrow(global::android.widget.AlphabetIndexer.staticClass, "<init>", "(Landroid/database/Cursor;ILjava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AlphabetIndexer.staticClass, global::android.widget.AlphabetIndexer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AlphabetIndexer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AlphabetIndexer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AlphabetIndexer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
