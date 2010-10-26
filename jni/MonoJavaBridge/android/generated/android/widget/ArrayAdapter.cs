namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayAdapter()
		{
			InitJNI();
		}
		protected ArrayAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add16702;
		public virtual void add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._add16702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._add16702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear16703;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._clear16703);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._clear16703);
		}
		internal static global::MonoJavaBridge.MethodId _remove16704;
		public virtual void remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._remove16704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._remove16704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext16705;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getContext16705)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getContext16705)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _insert16706;
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._insert16706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._insert16706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort16707;
		public virtual void sort(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._sort16707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._sort16707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPosition16708;
		public virtual int getPosition(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getPosition16708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getPosition16708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount16709;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getCount16709);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getCount16709);
		}
		internal static global::MonoJavaBridge.MethodId _getItem16710;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItem16710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItem16710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId16711;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItemId16711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItemId16711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16712;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getFilter16712)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getFilter16712)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _getView16713;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getView16713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getView16713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView16714;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getDropDownView16714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getDropDownView16714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16715;
		public override void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._notifyDataSetChanged16715);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._notifyDataSetChanged16715);
		}
		internal static global::MonoJavaBridge.MethodId _setNotifyOnChange16716;
		public virtual void setNotifyOnChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setNotifyOnChange16716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setNotifyOnChange16716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource16717;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setDropDownViewResource16717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setDropDownViewResource16717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromResource16718;
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._createFromResource16718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.ArrayAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16719;
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16720;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16721;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16722;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16723;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter16724;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter16724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ArrayAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ArrayAdapter"));
			global::android.widget.ArrayAdapter._add16702 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._clear16703 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "clear", "()V");
			global::android.widget.ArrayAdapter._remove16704 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._getContext16705 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.widget.ArrayAdapter._insert16706 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V");
			global::android.widget.ArrayAdapter._sort16707 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V");
			global::android.widget.ArrayAdapter._getPosition16708 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I");
			global::android.widget.ArrayAdapter._getCount16709 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I");
			global::android.widget.ArrayAdapter._getItem16710 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ArrayAdapter._getItemId16711 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.ArrayAdapter._getFilter16712 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.ArrayAdapter._getView16713 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._getDropDownView16714 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._notifyDataSetChanged16715 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.ArrayAdapter._setNotifyOnChange16716 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V");
			global::android.widget.ArrayAdapter._setDropDownViewResource16717 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ArrayAdapter._createFromResource16718 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;");
			global::android.widget.ArrayAdapter._ArrayAdapter16719 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.widget.ArrayAdapter._ArrayAdapter16720 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.widget.ArrayAdapter._ArrayAdapter16721 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter16722 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter16723 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter16724 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
		}
	}
}
