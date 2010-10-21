namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedList : java.util.AbstractSequentialList, List, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedList()
		{
			InitJNI();
		}
		protected LinkedList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26229;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._add26229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add26229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26230;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._add26230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add26230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get26231;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._get26231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._get26231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone26232;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._clone26232)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clone26232)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26233;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._indexOf26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._indexOf26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26234;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._clear26234);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clear26234);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26235;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._lastIndexOf26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._lastIndexOf26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26236;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._contains26236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._contains26236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26237;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26238;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll26238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll26238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26239;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._size26239);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._size26239);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26240;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray26240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray26240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26241;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray26241)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray26241)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _push26242;
		public virtual void push(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._push26242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._push26242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pop26243;
		public virtual global::java.lang.Object pop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pop26243)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pop26243)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26244;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove26244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26245;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._remove26245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26246;
		public virtual global::java.lang.Object remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove26246)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove26246)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26247;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._set26247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._set26247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26248;
		public override global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._listIterator26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._listIterator26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _poll26249;
		public virtual global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._poll26249)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._poll26249)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26250;
		public virtual global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peek26250)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peek26250)) as java.lang.Object;
		}
		public new global::java.lang.Object First
		{
			get
			{
				return getFirst();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirst26251;
		public virtual global::java.lang.Object getFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getFirst26251)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getFirst26251)) as java.lang.Object;
		}
		public new global::java.lang.Object Last
		{
			get
			{
				return getLast();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLast26252;
		public virtual global::java.lang.Object getLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getLast26252)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getLast26252)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirst26253;
		public virtual global::java.lang.Object removeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeFirst26253)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirst26253)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeLast26254;
		public virtual global::java.lang.Object removeLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeLast26254)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLast26254)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addFirst26255;
		public virtual void addFirst(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addFirst26255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addFirst26255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addLast26256;
		public virtual void addLast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addLast26256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addLast26256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _element26257;
		public virtual global::java.lang.Object element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._element26257)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._element26257)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26258;
		public virtual bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offer26258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offer26258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerFirst26259;
		public virtual bool offerFirst(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerFirst26259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerFirst26259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerLast26260;
		public virtual bool offerLast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerLast26260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerLast26260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekFirst26261;
		public virtual global::java.lang.Object peekFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekFirst26261)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekFirst26261)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peekLast26262;
		public virtual global::java.lang.Object peekLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekLast26262)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekLast26262)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst26263;
		public virtual global::java.lang.Object pollFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollFirst26263)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollFirst26263)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast26264;
		public virtual global::java.lang.Object pollLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollLast26264)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollLast26264)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirstOccurrence26265;
		public virtual bool removeFirstOccurrence(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeFirstOccurrence26265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirstOccurrence26265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeLastOccurrence26266;
		public virtual bool removeLastOccurrence(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeLastOccurrence26266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLastOccurrence26266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator26267;
		public virtual global::java.util.Iterator descendingIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._descendingIterator26267)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._descendingIterator26267)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26268;
		public LinkedList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26269;
		public LinkedList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26269);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedList"));
			global::java.util.LinkedList._add26229 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._add26230 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.LinkedList._get26231 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._clone26232 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.LinkedList._indexOf26233 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._clear26234 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clear", "()V");
			global::java.util.LinkedList._lastIndexOf26235 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._contains26236 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._addAll26237 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.LinkedList._addAll26238 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.LinkedList._size26239 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "size", "()I");
			global::java.util.LinkedList._toArray26240 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.LinkedList._toArray26241 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.LinkedList._push26242 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "push", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._pop26243 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pop", "()Ljava/lang/Object;");
			global::java.util.LinkedList._remove26244 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._remove26245 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._remove26246 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.LinkedList._set26247 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.LinkedList._listIterator26248 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.LinkedList._poll26249 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peek26250 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getFirst26251 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getLast26252 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirst26253 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeLast26254 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._addFirst26255 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addFirst", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._addLast26256 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addLast", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._element26257 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.LinkedList._offer26258 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerFirst26259 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerFirst", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerLast26260 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerLast", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._peekFirst26261 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peekLast26262 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollFirst26263 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollLast26264 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirstOccurrence26265 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._removeLastOccurrence26266 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._descendingIterator26267 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			global::java.util.LinkedList._LinkedList26268 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.LinkedList._LinkedList26269 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "()V");
		}
	}
}
