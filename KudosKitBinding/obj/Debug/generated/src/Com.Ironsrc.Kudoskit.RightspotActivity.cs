using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ironsrc.Kudoskit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']"
	[global::Android.Runtime.Register ("com/ironsrc/kudoskit/RightspotActivity", DoNotGenerateAcw=true)]
	public partial class RightspotActivity : global::Android.App.Activity, global::Com.Ironsrc.Kudoskit.KudosKit.IListener {


		static IntPtr ALWAYS_WORKING_FEATURES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='ALWAYS_WORKING_FEATURES']"
		[Register ("ALWAYS_WORKING_FEATURES")]
		public static IList<string> AlwaysWorkingFeatures {
			get {
				if (ALWAYS_WORKING_FEATURES_jfieldId == IntPtr.Zero)
					ALWAYS_WORKING_FEATURES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_WORKING_FEATURES", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALWAYS_WORKING_FEATURES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALWAYS_WORKING_FEATURES_jfieldId == IntPtr.Zero)
					ALWAYS_WORKING_FEATURES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_WORKING_FEATURES", "[Ljava/lang/String;");
				IntPtr native_value = JavaArray<string>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ALWAYS_WORKING_FEATURES_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='JAVASCRIPT_OBJECT_NAME']"
		[Register ("JAVASCRIPT_OBJECT_NAME")]
		public const string JavascriptObjectName = (string) "Appreciate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='KUDOSKIT_URL_STRING']"
		[Register ("KUDOSKIT_URL_STRING")]
		public const string KudoskitUrlString = (string) "http://kudos-kit.com/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='RIGHTSPOT_CONFIG']"
		[Register ("RIGHTSPOT_CONFIG")]
		public const string RightspotConfig = (string) "com.ironsrc.kudoskit.RightspotActivity.RIGHTSPOT_CONFIG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='RIGHTSPOT_NAME']"
		[Register ("RIGHTSPOT_NAME")]
		public const string RightspotName = (string) "com.ironsrc.kudoskit.RightspotActivity.RIGHTSPOT_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/field[@name='RIGHTSPOT_URL']"
		[Register ("RIGHTSPOT_URL")]
		public const string RightspotUrl = (string) "com.ironsrc.kudoskit.RightspotActivity.RIGHTSPOT_URL";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.FadeAnimation']"
		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/RightspotActivity$FadeAnimation", DoNotGenerateAcw=true)]
		public partial class FadeAnimation : global::Java.Lang.Object {


			static IntPtr mView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.FadeAnimation']/field[@name='mView']"
			[Register ("mView")]
			protected global::Android.Views.View MView {
				get {
					if (mView_jfieldId == IntPtr.Zero)
						mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Landroid/view/View;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mView_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mView_jfieldId == IntPtr.Zero)
						mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Landroid/view/View;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mView_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ironsrc/kudoskit/RightspotActivity$FadeAnimation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FadeAnimation); }
			}

			protected FadeAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.FadeAnimation']/constructor[@name='RightspotActivity.FadeAnimation' and count(parameter)=2 and parameter[1][@type='com.ironsrc.kudoskit.RightspotActivity'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/ironsrc/kudoskit/RightspotActivity;Landroid/view/View;)V", "")]
			public FadeAnimation (global::Com.Ironsrc.Kudoskit.RightspotActivity __self, global::Android.Views.View p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (FadeAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ironsrc/kudoskit/RightspotActivity;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_fadeIn;
#pragma warning disable 0169
			static Delegate GetFadeInHandler ()
			{
				if (cb_fadeIn == null)
					cb_fadeIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FadeIn);
				return cb_fadeIn;
			}

			static void n_FadeIn (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ironsrc.Kudoskit.RightspotActivity.FadeAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity.FadeAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FadeIn ();
			}
#pragma warning restore 0169

			static IntPtr id_fadeIn;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.FadeAnimation']/method[@name='fadeIn' and count(parameter)=0]"
			[Register ("fadeIn", "()V", "GetFadeInHandler")]
			public virtual void FadeIn ()
			{
				if (id_fadeIn == IntPtr.Zero)
					id_fadeIn = JNIEnv.GetMethodID (class_ref, "fadeIn", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fadeIn);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fadeIn", "()V"));
			}

			static Delegate cb_fadeOut_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetFadeOut_Landroid_app_Activity_Handler ()
			{
				if (cb_fadeOut_Landroid_app_Activity_ == null)
					cb_fadeOut_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FadeOut_Landroid_app_Activity_);
				return cb_fadeOut_Landroid_app_Activity_;
			}

			static void n_FadeOut_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ironsrc.Kudoskit.RightspotActivity.FadeAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity.FadeAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.FadeOut (p0);
			}
#pragma warning restore 0169

			static IntPtr id_fadeOut_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.FadeAnimation']/method[@name='fadeOut' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("fadeOut", "(Landroid/app/Activity;)V", "GetFadeOut_Landroid_app_Activity_Handler")]
			public virtual void FadeOut (global::Android.App.Activity p0)
			{
				if (id_fadeOut_Landroid_app_Activity_ == IntPtr.Zero)
					id_fadeOut_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "fadeOut", "(Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fadeOut_Landroid_app_Activity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fadeOut", "(Landroid/app/Activity;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.HoneycombFadeAnimation']"
		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/RightspotActivity$HoneycombFadeAnimation", DoNotGenerateAcw=true)]
		public partial class HoneycombFadeAnimation : global::Com.Ironsrc.Kudoskit.RightspotActivity.FadeAnimation {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ironsrc/kudoskit/RightspotActivity$HoneycombFadeAnimation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HoneycombFadeAnimation); }
			}

			protected HoneycombFadeAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.HoneycombFadeAnimation']/constructor[@name='RightspotActivity.HoneycombFadeAnimation' and count(parameter)=2 and parameter[1][@type='com.ironsrc.kudoskit.RightspotActivity'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/ironsrc/kudoskit/RightspotActivity;Landroid/view/View;)V", "")]
			public HoneycombFadeAnimation (global::Com.Ironsrc.Kudoskit.RightspotActivity __self, global::Android.Views.View p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (HoneycombFadeAnimation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ironsrc/kudoskit/RightspotActivity;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_ironsrc_kudoskit_RightspotActivity_Landroid_view_View_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_fadeIn;
#pragma warning disable 0169
			static Delegate GetFadeInHandler ()
			{
				if (cb_fadeIn == null)
					cb_fadeIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FadeIn);
				return cb_fadeIn;
			}

			static void n_FadeIn (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ironsrc.Kudoskit.RightspotActivity.HoneycombFadeAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity.HoneycombFadeAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FadeIn ();
			}
#pragma warning restore 0169

			static IntPtr id_fadeIn;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.HoneycombFadeAnimation']/method[@name='fadeIn' and count(parameter)=0]"
			[Register ("fadeIn", "()V", "GetFadeInHandler")]
			public override void FadeIn ()
			{
				if (id_fadeIn == IntPtr.Zero)
					id_fadeIn = JNIEnv.GetMethodID (class_ref, "fadeIn", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fadeIn);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fadeIn", "()V"));
			}

			static Delegate cb_fadeOut_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetFadeOut_Landroid_app_Activity_Handler ()
			{
				if (cb_fadeOut_Landroid_app_Activity_ == null)
					cb_fadeOut_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FadeOut_Landroid_app_Activity_);
				return cb_fadeOut_Landroid_app_Activity_;
			}

			static void n_FadeOut_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ironsrc.Kudoskit.RightspotActivity.HoneycombFadeAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity.HoneycombFadeAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.FadeOut (p0);
			}
#pragma warning restore 0169

			static IntPtr id_fadeOut_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity.HoneycombFadeAnimation']/method[@name='fadeOut' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("fadeOut", "(Landroid/app/Activity;)V", "GetFadeOut_Landroid_app_Activity_Handler")]
			public override void FadeOut (global::Android.App.Activity p0)
			{
				if (id_fadeOut_Landroid_app_Activity_ == IntPtr.Zero)
					id_fadeOut_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "fadeOut", "(Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fadeOut_Landroid_app_Activity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fadeOut", "(Landroid/app/Activity;)V"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ironsrc/kudoskit/RightspotActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RightspotActivity); }
		}

		protected RightspotActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/constructor[@name='RightspotActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RightspotActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RightspotActivity)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.RightspotActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
		}

		static Delegate cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler ()
		{
			if (cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == null)
				cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_);
			return cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
		}

		static void n_OnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.RightspotActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0 = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKudosKitEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/method[@name='onKudosKitEvent' and count(parameter)=2 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit.EventId'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onKudosKitEvent", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V", "GetOnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler")]
		public virtual void OnKudosKitEvent (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1)
		{
			if (id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == IntPtr.Zero)
				id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onKudosKitEvent", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKudosKitEvent", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RightspotCommand_Ljava_lang_String_Ljava_lang_String_);
			return cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_RightspotCommand_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.RightspotActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.RightspotActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RightspotCommand (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='RightspotActivity']/method[@name='rightspotCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("rightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool RightspotCommand (string p0, string p1)
		{
			if (id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
